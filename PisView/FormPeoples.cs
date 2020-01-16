using Controllers;
using Model;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormPeoples : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly PeopleController service;
        private readonly BackupController backupService;

        public FormPeoples(PeopleController service, BackupController backupService)
        {
            InitializeComponent();
            this.service = service;
            this.backupService = backupService;
        }

        private void FormPeoples_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<PeopleViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = true;
                    dataGridView.Columns[2].Visible = true;
                    dataGridView.Columns[3].Visible = false;
                    dataGridView.Columns[6].Visible = false;
                    dataGridView.Columns[7].Visible = false;
                    dataGridView.Columns[8].Visible = true;
                    dataGridView.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }

                List<ReportViewModel> listNumberHouse1 = service.GetListNumberHouse();
                if (listNumberHouse1 != null)
                {
                    comboBoxNumberHouse1.DisplayMember = "Adres";
                    comboBoxNumberHouse1.DataSource = listNumberHouse1;
                    comboBoxNumberHouse1.SelectedItem = null;
                }

                List<ReportViewModel> listNumberHouse2 = service.GetListNumberHouse();
                if (listNumberHouse2 != null)
                {
                    comboBoxNumberHouse2.DisplayMember = "Adres";
                    comboBoxNumberHouse2.DataSource = listNumberHouse2;
                    comboBoxNumberHouse2.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPeople>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormPeople>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        backupService.SaveToJsonAsync("D:\\BackupDeleteClient" + id +".json");
                        MessageBox.Show("Данные скопированы в архив", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        service.DelElement(id);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSerchByFIO_Click(object sender, EventArgs e)
        {
            try
            {
                List<PeopleViewModel> list = service.Search(textBoxSerch.Text);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = true;
                    dataGridView.Columns[2].Visible = true;
                    dataGridView.Columns[3].Visible = false;
                    dataGridView.Columns[6].Visible = false;
                    dataGridView.Columns[7].Visible = false;
                    dataGridView.Columns[8].Visible = true;
                    dataGridView.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSelectByHouseNumber_Click(object sender, EventArgs e)
        {
            try
            {
                List<PeopleViewModel> list = service.SelectByHouseNumber(textBoxSerch.Text);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = true;
                    dataGridView.Columns[2].Visible = true;
                    dataGridView.Columns[3].Visible = false;
                    dataGridView.Columns[6].Visible = false;
                    dataGridView.Columns[7].Visible = false;
                    dataGridView.Columns[8].Visible = true;
                    dataGridView.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSelectByCountPeople_Click(object sender, EventArgs e)
        {
            try
            {
                List<PeopleViewModel> list = service.SelectByCountPeople(Convert.ToInt32(textBoxSerch.Text));
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = false;
                    dataGridView.Columns[2].Visible = false;
                    dataGridView.Columns[3].Visible = false;
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
        }

        private void buttonAverageLivingSpace_Click(object sender, EventArgs e)
        {
            try
            {
                List<PeopleViewModel> list = service.SelectAverageLivingSpace();
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = false;
                    dataGridView.Columns[2].Visible = false;
                    dataGridView.Columns[3].Visible = false;
                    dataGridView.Columns[6].Visible = false;
                    dataGridView.Columns[7].Visible = true;
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
        }

        private void buttonTradeApartment_Click(object sender, EventArgs e)
        {
            service.TradeApartment(Convert.ToInt32(comboBoxNumberApartment1.SelectedValue), Convert.ToInt32(comboBoxNumberApartment2.SelectedValue));
            LoadData();
        }

        private void comboBoxNumberHouse1_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Apartment> list = service.GetListApartment(comboBoxNumberHouse1.Text);
            if (list != null)
            {
                comboBoxNumberApartment1.DisplayMember = "NumberApartment";
                comboBoxNumberApartment1.ValueMember = "Id";
                comboBoxNumberApartment1.DataSource = list;
                comboBoxNumberApartment1.SelectedItem = null;
            }
        }

        private void comboBoxNumberHouse2_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Apartment> list = service.GetListApartment(comboBoxNumberHouse2.Text);
            if (list != null)
            {
                comboBoxNumberApartment2.DisplayMember = "NumberApartment";
                comboBoxNumberApartment2.ValueMember = "Id";
                comboBoxNumberApartment2.DataSource = list;
                comboBoxNumberApartment2.SelectedItem = null;
            }
        }
    }
}
