namespace View
{
    partial class FormPeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxPrivileges = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrivilege = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumberApartment = new System.Windows.Forms.Label();
            this.comboBoxNumberApartment = new System.Windows.Forms.ComboBox();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.comboBoxNumberHouse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(417, 362);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 28);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(324, 362);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(89, 28);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxPrivileges
            // 
            this.groupBoxPrivileges.Controls.Add(this.label1);
            this.groupBoxPrivileges.Controls.Add(this.comboBoxPrivilege);
            this.groupBoxPrivileges.Controls.Add(this.dataGridView);
            this.groupBoxPrivileges.Controls.Add(this.buttonDel);
            this.groupBoxPrivileges.Controls.Add(this.buttonAdd);
            this.groupBoxPrivileges.Location = new System.Drawing.Point(19, 103);
            this.groupBoxPrivileges.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPrivileges.Name = "groupBoxPrivileges";
            this.groupBoxPrivileges.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPrivileges.Size = new System.Drawing.Size(487, 248);
            this.groupBoxPrivileges.TabIndex = 11;
            this.groupBoxPrivileges.TabStop = false;
            this.groupBoxPrivileges.Text = "Льготы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Льгота:";
            // 
            // comboBoxPrivilege
            // 
            this.comboBoxPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivilege.FormattingEnabled = true;
            this.comboBoxPrivilege.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxPrivilege.Location = new System.Drawing.Point(370, 28);
            this.comboBoxPrivilege.Name = "comboBoxPrivilege";
            this.comboBoxPrivilege.Size = new System.Drawing.Size(111, 21);
            this.comboBoxPrivilege.TabIndex = 17;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(4, 17);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(314, 226);
            this.dataGridView.TabIndex = 4;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(370, 84);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(111, 26);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(370, 54);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 26);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(68, 11);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(7, 37);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(111, 13);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Владелец квартиры:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 11);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "ФИО:";
            // 
            // labelNumberApartment
            // 
            this.labelNumberApartment.AutoSize = true;
            this.labelNumberApartment.Location = new System.Drawing.Point(265, 67);
            this.labelNumberApartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberApartment.Name = "labelNumberApartment";
            this.labelNumberApartment.Size = new System.Drawing.Size(96, 13);
            this.labelNumberApartment.TabIndex = 14;
            this.labelNumberApartment.Text = "Номер квартиры:";
            // 
            // comboBoxNumberApartment
            // 
            this.comboBoxNumberApartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberApartment.FormattingEnabled = true;
            this.comboBoxNumberApartment.Location = new System.Drawing.Point(380, 64);
            this.comboBoxNumberApartment.Name = "comboBoxNumberApartment";
            this.comboBoxNumberApartment.Size = new System.Drawing.Size(128, 21);
            this.comboBoxNumberApartment.TabIndex = 15;
            // 
            // comboBoxOwner
            // 
            this.comboBoxOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxOwner.Location = new System.Drawing.Point(123, 34);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new System.Drawing.Size(128, 21);
            this.comboBoxOwner.TabIndex = 16;
            // 
            // comboBoxNumberHouse
            // 
            this.comboBoxNumberHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberHouse.FormattingEnabled = true;
            this.comboBoxNumberHouse.Items.AddRange(new object[] {
            "Радищева 44",
            "Орлова 26"});
            this.comboBoxNumberHouse.Location = new System.Drawing.Point(123, 64);
            this.comboBoxNumberHouse.Name = "comboBoxNumberHouse";
            this.comboBoxNumberHouse.Size = new System.Drawing.Size(128, 21);
            this.comboBoxNumberHouse.TabIndex = 18;
            this.comboBoxNumberHouse.SelectedValueChanged += new System.EventHandler(this.comboBoxNumberHouse_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Номер дома :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // FormPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 401);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxNumberHouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOwner);
            this.Controls.Add(this.comboBoxNumberApartment);
            this.Controls.Add(this.labelNumberApartment);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxPrivileges);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Name = "FormPeople";
            this.Text = "Данные жильца";
            this.Load += new System.EventHandler(this.FormPeople_Load);
            this.groupBoxPrivileges.ResumeLayout(false);
            this.groupBoxPrivileges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxPrivileges;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumberApartment;
        private System.Windows.Forms.ComboBox comboBoxNumberApartment;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.ComboBox comboBoxPrivilege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNumberHouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}