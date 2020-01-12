using Controllers;
using Model;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormPeoplePrivilege : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public PeoplePrivilegeViewModel Model
        {
            set { model = value; }
            get
            {
                return model;
            }
        }
        private readonly PrivilegeController service;
        private PeoplePrivilegeViewModel model;
        public FormPeoplePrivilege(PrivilegeController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormPeoplePrivilege_Load(object sender, EventArgs e)
        {
            try
            {
                List<Privilege> list = service.GetList();
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
                Privilege view = service.GetElement(Convert.ToInt32(comboBoxPrivilege.SelectedValue));
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
