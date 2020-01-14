using iTextSharp.text;
using iTextSharp.text.pdf;
using Model;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Controllers
{
    public class ReportController
    {
        private PisDbContext context;
        public ReportController(PisDbContext context)
        {
            this.context = context;
        }

        //Количество жильцов в каждой квартире
        public List<PeopleViewModel> SelectCountPeopleInApart(string dateFrom, string dateTo, string NumberHouse)
        {
            var dt = context.Database.SqlQuery<PeopleViewModel>("select Concat(Apartments.NumberHouse, ' кв ', Apartments.NumberApartment) as 'NumberHouse', Count(ApartmentId) as 'CountPeople' from People, Apartments where People.ApartmentId = Apartments.Id AND People.Date BETWEEN  '" + dateFrom + "' and '" + dateTo + "' AND Apartments.NumberHouse LIKE '" + NumberHouse + "%' Group by Apartments.NumberHouse, Apartments.NumberApartment");
            List<PeopleViewModel> result = dt.ToList();
            return result;
        }

        // перекрестный отчет по льготам и квартирам
        public List<ReportViewModel> SelectApartmentPrivilege(string dateFrom, string dateTo, string NumberHouse)
        {
            var dt = context.Database.SqlQuery<ReportViewModel>("select  Concat(Apartments.NumberHouse, ' кв ', Apartments.NumberApartment) as 'Adres', SUM(CASE WHEN PeoplePrivileges.PeopleId LIKE People.Id AND Privileges.TypePrivilege LIKE 'На газ' AND PeoplePrivileges.PrivilegeId LIKE Privileges.Id THEN 1 ELSE 0 END) AS 'NaGas', SUM(CASE WHEN PeoplePrivileges.PeopleId LIKE People.Id AND Privileges.TypePrivilege LIKE 'На воду' AND PeoplePrivileges.PrivilegeId LIKE Privileges.Id THEN 1 ELSE 0 END) AS 'NaVodu', SUM(CASE WHEN PeoplePrivileges.PeopleId LIKE People.Id AND Privileges.TypePrivilege LIKE 'На общедомовые нужды' AND PeoplePrivileges.PrivilegeId LIKE Privileges.Id THEN 1 ELSE 0 END) AS 'NaObchedomovie', SUM(CASE WHEN PeoplePrivileges.PeopleId LIKE People.Id AND Privileges.TypePrivilege LIKE 'На электричество' AND PeoplePrivileges.PrivilegeId LIKE Privileges.Id THEN 1 ELSE 0 END) AS 'NaElectr' from People, Apartments, PeoplePrivileges, Privileges where People.ApartmentId = Apartments.Id AND People.Date BETWEEN  '" + dateFrom + "' and '" + dateTo + "' AND Apartments.NumberHouse LIKE '" + NumberHouse + "%' Group by Apartments.NumberHouse, Apartments.NumberApartment");
            List<ReportViewModel> result = dt.ToList();
            return result;
        }

        // состав семьи
        public List<PeopleViewModel> SelectFamilyComposition(string dateFrom, string dateTo, string FIO)
        {
            var dt = context.Database.SqlQuery<PeopleViewModel>("select People.FIO, Concat(Apartments.NumberHouse, ' кв ', Apartments.NumberApartment) as 'NumberHouse' from People, Apartments where (People.ApartmentId = (select People.ApartmentId from People where People.FIO = '" + FIO + "') AND People.ApartmentId = Apartments.Id AND People.Date BETWEEN  '" + dateFrom + "' and '" + dateTo + "')");
            List<PeopleViewModel> result = dt.ToList();
            return result;
        }


        public void savePDF(string FileName, string title, DataGridView dataGridView1, string Itogo, string UserFIO)
        {
            int countColumn = 0;
            string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
            BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
            iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)

            var phraseTitle = new Phrase(title,
            new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Paragraph paragraph = new
           iTextSharp.text.Paragraph(phraseTitle)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 12
            };

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Visible == true) countColumn++;
            }

            PdfPTable table = new PdfPTable(countColumn);

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].Visible == true)
                {
                    table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderCell.Value.ToString(), fontParagraph));
                    countColumn++;
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Columns[j].Visible == true)
                    {
                        table.AddCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString(), fontParagraph));
                    }
                }
            }

            var phraseSum = new Phrase(Itogo,
            new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Paragraph paragraphSum = new
           iTextSharp.text.Paragraph(phraseSum)
            {
                Alignment = Element.ALIGN_RIGHT - 1,
                SpacingAfter = 12,
            };

            var phraseUser = new Phrase("Заверил пасспортист: " + UserFIO + " Роспись:          от " + DateTime.Now + "",
            new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Paragraph paragraphUser = new
           iTextSharp.text.Paragraph(phraseUser)
            {
                Alignment = Element.ALIGN_RIGHT - 1,
                SpacingAfter = 12,
            };

            using (FileStream stream = new FileStream(FileName, FileMode.Create))
            {
                iTextSharp.text.Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(paragraph);
                pdfDoc.Add(table);
                pdfDoc.Add(paragraphSum);
                pdfDoc.Add(paragraphUser);
                pdfDoc.Close();
                stream.Close();
            }
        }

        public void saveDiagramm(string FileName, string title, Chart chart, string UserFIO)
        {
            try
            {
                string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
                BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
                iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)

                var phraseTitle = new Phrase(title,
                new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD));
                iTextSharp.text.Paragraph paragraph = new
               iTextSharp.text.Paragraph(phraseTitle)
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 12
                };

                chart.SaveImage(FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);

                var phraseUser = new Phrase("Заверил пасспортист: " + UserFIO + " Роспись:          от " + DateTime.Now + "",
            new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
                iTextSharp.text.Paragraph paragraphUser = new
               iTextSharp.text.Paragraph(phraseUser)
                {
                    Alignment = Element.ALIGN_RIGHT - 2,
                    SpacingAfter = 12,
                };

                Document document = new Document();
                Stream myStream;
                using (var stream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None))

                {
                    PdfWriter.GetInstance(document, stream);
                    document.Open();
                    using (var imageStream = new FileStream(FileName + ".png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var image = Image.GetInstance(imageStream);
                        document.Add(paragraph);
                        document.Add(image);
                        document.Add(paragraphUser);
                    }
                    document.Close();
                    File.Delete(FileName + ".png");
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
    
}
