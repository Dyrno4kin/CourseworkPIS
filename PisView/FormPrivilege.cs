using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormPrivilege : Form
    {
        private int id;
        public FormPrivilege()
        {
            InitializeComponent();
        }

        private void FormPrivilege_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Privilege> list =
                APIClient.GetRequest<List<Privilege>>("api/Privilege/GetList");
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode =
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
            if (string.IsNullOrEmpty(textBoxNamePrivilege.Text))
            {
                MessageBox.Show("Заполните название льготы", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxMultiplier.Text))
            {
                MessageBox.Show("Заполните коэффициэнт", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxTypePrivilege.Text))
            {
                MessageBox.Show("Выберите тип льготы", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            APIClient.PostRequest<Privilege, bool>("api/Privilege/AddElement", new Privilege
            {
                NamePrivilege = textBoxNamePrivilege.Text,
                TypePrivilege = comboBoxTypePrivilege.Text,
                Multiplier = Convert.ToDouble(textBoxMultiplier.Text)
            });
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNamePrivilege.Text))
            {
                MessageBox.Show("Заполните название льготы", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxMultiplier.Text))
            {
                MessageBox.Show("Заполните коэффициэнт", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxTypePrivilege.Text))
            {
                MessageBox.Show("Выберите тип льготы", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            APIClient.PostRequest<Privilege,
                    bool>("api/Privilege/UpdElement", new Privilege
                    {
                        Id = id,
                        NamePrivilege = textBoxNamePrivilege.Text,
                        TypePrivilege = comboBoxTypePrivilege.Text,
                        Multiplier = Convert.ToDouble(textBoxMultiplier.Text)
                        
                    });
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        APIClient.PostRequest<Privilege,
                        bool>("api/Privilege/DelElement", new Privilege { Id = id });
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    Privilege view = APIClient.GetRequest<Privilege>("api/Privilege/Get/" + id);
                    textBoxMultiplier.Text = Convert.ToString(view.Multiplier);
                    textBoxNamePrivilege.Text = view.NamePrivilege;
                    comboBoxTypePrivilege.Text = view.TypePrivilege;
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
