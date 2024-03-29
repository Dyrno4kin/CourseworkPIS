﻿using Controllers;
using Model;
using System;
using System.Windows.Forms;
using Unity;
using View;

namespace ViewAuthorization
{
    public partial class FormLogin : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly MainController mainService;

        public FormLogin(MainController mainService)
        {
            InitializeComponent();
            this.mainService = mainService;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                User view = mainService.GetElement(textBoxLogin.Text, textBoxPassword.Text);
                if (!string.IsNullOrEmpty(view.UserFIO))
                {

                    if (view.UserRole == "Пасспортист")
                    {
                        this.Visible = false;
                        FormStart formStart = new FormStart();
                        formStart.Dispose();
                        var form = Container.Resolve<FormMain>();
                        form.fio = view.UserFIO;
                        form.ShowDialog();
                    }
                    if (view.UserRole == "Бухгалтер")
                    {
                        MessageBox.Show("ARM Бухгалтера в данный момент недоступна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (view.UserRole == "Руководитель")
                    {
                        MessageBox.Show("АРМ Руководителя в данный момент недоступна", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            return;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '●';
        }
    }
}
