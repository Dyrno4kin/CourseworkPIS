using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public string fio { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonListPrivilege_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPrivilege>();
            form.ShowDialog();
        }

        private void buttonListPeople_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPeoples>();
            form.ShowDialog();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReport>();
            form.fio = fio;
            form.ShowDialog();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програма была разработана для автоматизации жилищного кооператива. Данный модуль поможет автоматизировать деятельнось пасспортиста. Данную программу сделал студент гр. ИСЭ-31. Он не спал последние пару ночей, подключенее к бд не удаленное, но есть кое-что получше", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            var form = new FormInfo();
            form.StartPosition = FormStartPosition.Manual;
            form.Left = 200;
            form.Top = 200;
            form.Show();

            var form1 = new FormInfo();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Left = 700;
            form1.Top = 200;
            form1.Show();

            var form2 = new FormInfo();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Left = 1200;
            form2.Top = 200;
            form2.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добрый день, "+fio+"", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
