using Controllers;
using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormPrivilege : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private int id;
        private readonly PrivilegeController service;
        public FormPrivilege(PrivilegeController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormPrivilege_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Privilege> list = service.GetList();
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
            try
            {
                service.AddElement(new Privilege
                {
                    NamePrivilege = textBoxNamePrivilege.Text,
                    TypePrivilege = comboBoxTypePrivilege.Text,
                    Multiplier = Convert.ToDouble(textBoxMultiplier.Text)
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Введите корректные значения", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
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
            try
            {
                service.UpdElement(new Privilege
                {
                    Id = id,
                    NamePrivilege = textBoxNamePrivilege.Text,
                    TypePrivilege = comboBoxTypePrivilege.Text,
                    Multiplier = Convert.ToDouble(textBoxMultiplier.Text)
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Введите корректные значения", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
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
                        service.DelElement(id);
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    Privilege view = service.GetElement(id);
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
