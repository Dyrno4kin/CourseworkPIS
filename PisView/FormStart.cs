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
    public partial class FormStart : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormLogin>();
            form.ShowDialog();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRegistration>();
            form.ShowDialog();
        }
    }
}
