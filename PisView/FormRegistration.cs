using Model;
using Controllers;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormRegistration : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly MainController mainService;

        public FormRegistration(MainController mainService)
        {
            InitializeComponent();
            this.mainService = mainService;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните Фио", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPass.Text))
            {
                MessageBox.Show("Придумайте пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxRole.Text))
            {
                MessageBox.Show("Выберите должность", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                mainService.AddElement(new User
                {
                    UserFIO = textBoxFIO.Text,
                    Login = textBoxLogin.Text,
                    Password = textBoxPass.Text,
                    UserRole = comboBoxRole.Text
                });
                MessageBox.Show("Регистрация прошла успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
