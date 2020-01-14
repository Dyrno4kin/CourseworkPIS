using Controllers;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormReport : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly PeopleController service;
        private readonly ReportController reportService;
        public string fio { get; set; }

        public FormReport(PeopleController service, ReportController reportService)
        {
            InitializeComponent();
            this.service = service;
            this.reportService = reportService;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
        }

        private void buttonPrivilegeApart_Click(object sender, EventArgs e)
        {
            string dateFrom = Convert.ToString(dateTimePicker1.Text);
            string dateTo = Convert.ToString(dateTimePicker2.Text);

            try
            {
                List<ReportViewModel> list = reportService.SelectApartmentPrivilege(dateFrom, dateTo, textBox1.Text);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].HeaderCell.Value = "Адрес";
                    dataGridView.Columns[1].HeaderCell.Value = "На газ";
                    dataGridView.Columns[2].HeaderCell.Value = "На воду";
                    dataGridView.Columns[3].HeaderCell.Value = "На общедомовые нужды";
                    dataGridView.Columns[4].HeaderCell.Value = "На электричество";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            int sum = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView.Columns.Count; j++)
                {
                    sum += Convert.ToInt32(dataGridView[j, i].Value);
                }
            }
            label2.Text = "Всего льгот: " + Convert.ToString(sum);

            if (MessageBox.Show("Напечатать отчет?", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string title = "Распределение льготников по квартирам и видам льгот с " + dateFrom + " по " + dateTo + " \n Текущая дата " + DateTime.Now + ".";
                if (dateTimePicker1.Value >= dateTimePicker2.Value)
                {
                    MessageBox.Show("Дата начала должна быть меньше даты окончания",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "pdf|*.pdf"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        reportService.savePDF(sfd.FileName, title, dataGridView, label2.Text, fio);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonDiagram_Click(object sender, EventArgs e)
        {
            string dateFrom = Convert.ToString(dateTimePicker1.Text);
            string dateTo = Convert.ToString(dateTimePicker2.Text);
            chart1.Series["NumberHouse"].XValueMember = "NumberHouse";
            chart1.Series["NumberHouse"].YValueMembers = "CountPeople";
            chart1.DataSource = reportService.SelectCountPeopleInApart(dateFrom, dateTo, textBox1.Text);
            chart1.DataBind();

            if (MessageBox.Show("Напечатать отчет?", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string title = "Диаграмма количества жильцов в каждой квартире с " + dateFrom + " по " + dateTo + " \n Текущая дата " + DateTime.Now + ".";
                if (dateTimePicker1.Value >= dateTimePicker2.Value)
                {
                    MessageBox.Show("Дата начала должна быть меньше даты окончания",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "pdf|*.pdf"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        reportService.saveDiagramm(sfd.FileName, title, chart1, fio);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonCountPeopleInApart_Click(object sender, EventArgs e)
        {
            string dateFrom = Convert.ToString(dateTimePicker1.Text);
            string dateTo = Convert.ToString(dateTimePicker2.Text);
            try
            {
                List<PeopleViewModel> list = reportService.SelectCountPeopleInApart(dateFrom, dateTo, textBox1.Text);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[4].HeaderCell.Value = "Адрес";
                    dataGridView.Columns[6].HeaderCell.Value = "Количество жильцов";
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = false;
                    dataGridView.Columns[2].Visible = false;
                    dataGridView.Columns[3].Visible = false;
                    dataGridView.Columns[5].Visible = false;
                    dataGridView.Columns[6].Visible = true;
                    dataGridView.Columns[7].Visible = false;
                    dataGridView.Columns[8].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[6].AutoSizeMode =
                   DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

            int count = 0;
            int sum = 0;
            while (count <= (Convert.ToInt32(dataGridView.RowCount.ToString()) - 1))
            {
                sum += Convert.ToInt32(dataGridView[6, count].Value);
                count++;
            }
            label2.Text = "Всего жильцов: " + Convert.ToString(sum);

            if (MessageBox.Show("Напечатать отчет?", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string title = "Поквартирный список с расчетом количества жильцов в каждой квартире с " + dateFrom + " по " + dateTo + " \n Текущая дата " + DateTime.Now + ".";
                if (dateTimePicker1.Value >= dateTimePicker2.Value)
                {
                    MessageBox.Show("Дата начала должна быть меньше даты окончания",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "pdf|*.pdf"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        reportService.savePDF(sfd.FileName, title, dataGridView, label2.Text, fio);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonFamily_Click(object sender, EventArgs e)
        {
            string dateFrom = Convert.ToString(dateTimePicker1.Text);
            string dateTo = Convert.ToString(dateTimePicker2.Text);
            try
            {
                List<PeopleViewModel> list = reportService.SelectFamilyComposition(dateFrom, dateTo, textBox1.Text);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[1].HeaderCell.Value = "Фио членов семьи";
                    dataGridView.Columns[4].HeaderCell.Value = "Адрес";
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = true;
                    dataGridView.Columns[2].Visible = false;
                    dataGridView.Columns[3].Visible = false;
                    dataGridView.Columns[5].Visible = false;
                    dataGridView.Columns[6].Visible = false;
                    dataGridView.Columns[7].Visible = false;
                    dataGridView.Columns[8].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[6].AutoSizeMode =
                   DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            int count = 0;
            while (count <= (Convert.ToInt32(dataGridView.RowCount.ToString()) - 1))
            {
                count++;
            }
            label2.Text = "Членов семьи: " + Convert.ToString(count);

            if (MessageBox.Show("Напечатать отчет?", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string title = "Справка о составе семьи жильца " + textBox1.Text + " с " + dateFrom + " по " + dateTo + " \n Текущая дата " + DateTime.Now + ".";
                if (dateTimePicker1.Value >= dateTimePicker2.Value)
                {
                    MessageBox.Show("Дата начала должна быть меньше даты окончания",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "pdf|*.pdf"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        reportService.savePDF(sfd.FileName, title, dataGridView, label2.Text, fio);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
