using Model;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FormPeoplePrivilege : Form
    {
        public PeoplePrivilegeViewModel Model
        {
            set { model = value; }
            get
            {
                return model;
            }
        }
        private PeoplePrivilegeViewModel model;
        public FormPeoplePrivilege()
        {
            InitializeComponent();
        }

        private void FormPeoplePrivilege_Load(object sender, EventArgs e)
        {
            try
            {
                List<Privilege> list = APIClient.GetRequest<List<Privilege>>("api/Privilege/GetList");
                if (list != null)
                {
                    comboBoxPrivilege.DisplayMember = "NamePrivilege";
                    comboBoxPrivilege.ValueMember = "Id";
                    comboBoxPrivilege.DataSource = list;
                    comboBoxPrivilege.SelectedItem = null;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPrivilege.SelectedValue == null)
            {
                MessageBox.Show("Выберите льготу", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                Privilege view = APIClient.GetRequest<Privilege>("api/Privilege/Get/" + Convert.ToInt32(comboBoxPrivilege.SelectedValue));
                if (model == null)
                {
                    model = new PeoplePrivilegeViewModel
                    {
                        PrivilegeId = Convert.ToInt32(comboBoxPrivilege.SelectedValue),
                        NamePrivilege = comboBoxPrivilege.Text,
                        Multiplier = view.Multiplier
                    };
                }
                else
                {
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
    }
}
