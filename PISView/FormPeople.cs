using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Controllers;
using Model;
using Model.ViewModels;
using Unity;

namespace View
{
    public partial class FormPeople : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private int? id;
        private readonly PeopleController service;
        private readonly PrivilegeController servicePrivilege;
        private List<PeoplePrivilegeViewModel> peoplePrivileges;


        public PeoplePrivilegeViewModel Model
        {
            set { model = value; }
            get
            {
                return model;
            }
        }
        private PeoplePrivilegeViewModel model;

        public FormPeople(PeopleController service, PrivilegeController servicePrivilege)
        {
            InitializeComponent();
            this.service = service;
            this.servicePrivilege = servicePrivilege;
        }

        private void FormPeople_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            try
            {
                List<Privilege> listPrivilege = servicePrivilege.GetList();
                if (listPrivilege != null)
                {
                    comboBoxPrivilege.DisplayMember = "NamePrivilege";
                    comboBoxPrivilege.ValueMember = "Id";
                    comboBoxPrivilege.DataSource = listPrivilege;
                    comboBoxPrivilege.SelectedItem = null;
                }

                List<ReportViewModel> listNumberHouse = service.GetListNumberHouse();
                if (listNumberHouse != null)
                {
                    comboBoxNumberHouse.DisplayMember = "Adres";
                    comboBoxNumberHouse.DataSource = listNumberHouse;
                    comboBoxNumberHouse.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

            if (id.HasValue)
            {
                try
                {
                    PeopleViewModel view = service.GetElement(id.Value);
                    textBoxName.Text = view.FIO;
                    comboBoxOwner.Text = view.Owner.ToString();
                    dateTimePicker1.Value = view.Date;
                    comboBoxNumberHouse.Text = view.NumberHouse;
                    List<Apartment> list = service.GetListApartment(comboBoxNumberHouse.Text);
                    if (list != null)
                    {
                        comboBoxNumberApartment.DisplayMember = "NumberApartment";
                        comboBoxNumberApartment.ValueMember = "Id";
                        comboBoxNumberApartment.DataSource = list;
                        comboBoxNumberApartment.SelectedItem = view.NumberApartment;
                    }
                    peoplePrivileges = view.PeoplePrivileges;
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                peoplePrivileges = new List<PeoplePrivilegeViewModel>();
            }       
        }

        private void LoadData()
        {
            try
            {
                if (peoplePrivileges != null)
                {
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = peoplePrivileges;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = false;
                    dataGridView.Columns[2].Visible = false;
                    dataGridView.Columns[3].Visible = true;
                    dataGridView.Columns[3].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill; 
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
            if (comboBoxPrivilege.SelectedValue == null)
            {
                MessageBox.Show("Выберите льготу", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }

            int count = 0;
            while (count <= (Convert.ToInt32(dataGridView.RowCount.ToString()) - 1))
            {
                if (dataGridView[3, count].Value.ToString() == comboBoxPrivilege.Text.ToString())
                {
                    MessageBox.Show("У клиента уже есть такая льгота", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }               
                count++;
            }
            try
            {
                Privilege view = servicePrivilege.GetElement(Convert.ToInt32(comboBoxPrivilege.SelectedValue));
                model = new PeoplePrivilegeViewModel
                {
                    PrivilegeId = Convert.ToInt32(comboBoxPrivilege.SelectedValue),
                    NamePrivilege = comboBoxPrivilege.Text,
                    Multiplier = view.Multiplier
                };
                peoplePrivileges.Add(Model);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        peoplePrivileges.RemoveAt(dataGridView.SelectedRows[0].Cells[0].RowIndex);
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxNumberApartment.Text))
            {
                MessageBox.Show("Выберите квартиру", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxOwner.Text))
            {
                MessageBox.Show("Выберите владельца", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<PeoplePrivilege> peoplePrivilegesBM = new List<PeoplePrivilege>();
                for (int i = 0; i < peoplePrivileges.Count; ++i)
                {
                    peoplePrivilegesBM.Add(new PeoplePrivilege
                    {
                        Id = peoplePrivileges[i].Id,
                        PeopleId = peoplePrivileges[i].PeopleId,
                        PrivilegeId = peoplePrivileges[i].PrivilegeId
                    });
                }
                if (id.HasValue)
                {
                    service.UpdElement(new People
                    {
                        Id = id.Value,
                        FIO = textBoxName.Text,
                        Owner = Convert.ToBoolean(comboBoxOwner.Text),
                        ApartmentId = Convert.ToInt32(comboBoxNumberApartment.SelectedValue),
                        Date = Convert.ToDateTime(dateTimePicker1.Text),
                        PeoplePrivileges = peoplePrivilegesBM
                    });
                }
                else
                {
                    service.AddElement(new People
                    {
                        FIO = textBoxName.Text,
                        Owner = Convert.ToBoolean(comboBoxOwner.Text),
                        ApartmentId = Convert.ToInt32(comboBoxNumberApartment.SelectedValue),
                        Date = Convert.ToDateTime(dateTimePicker1.Text),
                        PeoplePrivileges = peoplePrivilegesBM
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBoxNumberHouse_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Apartment> list = service.GetListApartment(comboBoxNumberHouse.Text);
            if (list != null)
            {
                comboBoxNumberApartment.DisplayMember = "NumberApartment";
                comboBoxNumberApartment.ValueMember = "Id";
                comboBoxNumberApartment.DataSource = list;
                comboBoxNumberApartment.SelectedItem = null;
            }
        }
    }
}
