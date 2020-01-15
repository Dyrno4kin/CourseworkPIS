namespace View
{
    partial class FormPeoples
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSerch = new System.Windows.Forms.TextBox();
            this.buttonSerchByFIO = new System.Windows.Forms.Button();
            this.buttonSelectByHouseNumber = new System.Windows.Forms.Button();
            this.buttonSelectByCountPeople = new System.Windows.Forms.Button();
            this.buttonAverageLivingSpace = new System.Windows.Forms.Button();
            this.buttonTradeApartment = new System.Windows.Forms.Button();
            this.comboBoxNumberHouse1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNumberApartment1 = new System.Windows.Forms.ComboBox();
            this.labelNumberApartment = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNumberApartment2 = new System.Windows.Forms.ComboBox();
            this.comboBoxNumberHouse2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 33);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(495, 276);
            this.dataGridView.TabIndex = 15;
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(513, 229);
            this.buttonUpd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(179, 25);
            this.buttonUpd.TabIndex = 14;
            this.buttonUpd.Text = "Обновить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(512, 200);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(180, 25);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(512, 171);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(180, 25);
            this.buttonChange.TabIndex = 12;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(511, 142);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 25);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSerch
            // 
            this.textBoxSerch.Location = new System.Drawing.Point(12, 7);
            this.textBoxSerch.Name = "textBoxSerch";
            this.textBoxSerch.Size = new System.Drawing.Size(494, 20);
            this.textBoxSerch.TabIndex = 16;
            // 
            // buttonSerchByFIO
            // 
            this.buttonSerchByFIO.Location = new System.Drawing.Point(511, 7);
            this.buttonSerchByFIO.Name = "buttonSerchByFIO";
            this.buttonSerchByFIO.Size = new System.Drawing.Size(180, 20);
            this.buttonSerchByFIO.TabIndex = 17;
            this.buttonSerchByFIO.Text = "Поиск по ФИО или по квартире";
            this.buttonSerchByFIO.UseVisualStyleBackColor = true;
            this.buttonSerchByFIO.Click += new System.EventHandler(this.buttonSerchByFIO_Click);
            // 
            // buttonSelectByHouseNumber
            // 
            this.buttonSelectByHouseNumber.Location = new System.Drawing.Point(511, 33);
            this.buttonSelectByHouseNumber.Name = "buttonSelectByHouseNumber";
            this.buttonSelectByHouseNumber.Size = new System.Drawing.Size(180, 20);
            this.buttonSelectByHouseNumber.TabIndex = 18;
            this.buttonSelectByHouseNumber.Text = "Выборка по номеру дома";
            this.buttonSelectByHouseNumber.UseVisualStyleBackColor = true;
            this.buttonSelectByHouseNumber.Click += new System.EventHandler(this.buttonSelectByHouseNumber_Click);
            // 
            // buttonSelectByCountPeople
            // 
            this.buttonSelectByCountPeople.Location = new System.Drawing.Point(511, 59);
            this.buttonSelectByCountPeople.Name = "buttonSelectByCountPeople";
            this.buttonSelectByCountPeople.Size = new System.Drawing.Size(180, 36);
            this.buttonSelectByCountPeople.TabIndex = 19;
            this.buttonSelectByCountPeople.Text = "Выборка по количеству жильцов";
            this.buttonSelectByCountPeople.UseVisualStyleBackColor = true;
            this.buttonSelectByCountPeople.Click += new System.EventHandler(this.buttonSelectByCountPeople_Click);
            // 
            // buttonAverageLivingSpace
            // 
            this.buttonAverageLivingSpace.Location = new System.Drawing.Point(511, 101);
            this.buttonAverageLivingSpace.Name = "buttonAverageLivingSpace";
            this.buttonAverageLivingSpace.Size = new System.Drawing.Size(180, 36);
            this.buttonAverageLivingSpace.TabIndex = 20;
            this.buttonAverageLivingSpace.Text = "Средняя жилплощадь на 1 жильца в квартире";
            this.buttonAverageLivingSpace.UseVisualStyleBackColor = true;
            this.buttonAverageLivingSpace.Click += new System.EventHandler(this.buttonAverageLivingSpace_Click);
            // 
            // buttonTradeApartment
            // 
            this.buttonTradeApartment.Location = new System.Drawing.Point(5, 73);
            this.buttonTradeApartment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTradeApartment.Name = "buttonTradeApartment";
            this.buttonTradeApartment.Size = new System.Drawing.Size(375, 25);
            this.buttonTradeApartment.TabIndex = 21;
            this.buttonTradeApartment.Text = "Обменять квартиры";
            this.buttonTradeApartment.UseVisualStyleBackColor = true;
            this.buttonTradeApartment.Click += new System.EventHandler(this.buttonTradeApartment_Click);
            // 
            // comboBoxNumberHouse1
            // 
            this.comboBoxNumberHouse1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberHouse1.FormattingEnabled = true;
            this.comboBoxNumberHouse1.Items.AddRange(new object[] {
            "Радищева 44",
            "Орлова 26"});
            this.comboBoxNumberHouse1.Location = new System.Drawing.Point(86, 18);
            this.comboBoxNumberHouse1.Name = "comboBoxNumberHouse1";
            this.comboBoxNumberHouse1.Size = new System.Drawing.Size(128, 21);
            this.comboBoxNumberHouse1.TabIndex = 25;
            this.comboBoxNumberHouse1.SelectedValueChanged += new System.EventHandler(this.comboBoxNumberHouse1_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Номер дома :";
            // 
            // comboBoxNumberApartment1
            // 
            this.comboBoxNumberApartment1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberApartment1.FormattingEnabled = true;
            this.comboBoxNumberApartment1.Location = new System.Drawing.Point(320, 18);
            this.comboBoxNumberApartment1.Name = "comboBoxNumberApartment1";
            this.comboBoxNumberApartment1.Size = new System.Drawing.Size(60, 21);
            this.comboBoxNumberApartment1.TabIndex = 23;
            // 
            // labelNumberApartment
            // 
            this.labelNumberApartment.AutoSize = true;
            this.labelNumberApartment.Location = new System.Drawing.Point(219, 21);
            this.labelNumberApartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberApartment.Name = "labelNumberApartment";
            this.labelNumberApartment.Size = new System.Drawing.Size(96, 13);
            this.labelNumberApartment.TabIndex = 22;
            this.labelNumberApartment.Text = "Номер квартиры:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTradeApartment);
            this.groupBox1.Controls.Add(this.comboBoxNumberApartment2);
            this.groupBox1.Controls.Add(this.comboBoxNumberHouse2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxNumberApartment1);
            this.groupBox1.Controls.Add(this.comboBoxNumberHouse1);
            this.groupBox1.Controls.Add(this.labelNumberApartment);
            this.groupBox1.Location = new System.Drawing.Point(12, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 108);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обмен квартирами";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Номер дома :";
            // 
            // comboBoxNumberApartment2
            // 
            this.comboBoxNumberApartment2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberApartment2.FormattingEnabled = true;
            this.comboBoxNumberApartment2.Location = new System.Drawing.Point(320, 47);
            this.comboBoxNumberApartment2.Name = "comboBoxNumberApartment2";
            this.comboBoxNumberApartment2.Size = new System.Drawing.Size(60, 21);
            this.comboBoxNumberApartment2.TabIndex = 27;
            // 
            // comboBoxNumberHouse2
            // 
            this.comboBoxNumberHouse2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberHouse2.FormattingEnabled = true;
            this.comboBoxNumberHouse2.Items.AddRange(new object[] {
            "Радищева 44",
            "Орлова 26"});
            this.comboBoxNumberHouse2.Location = new System.Drawing.Point(86, 47);
            this.comboBoxNumberHouse2.Name = "comboBoxNumberHouse2";
            this.comboBoxNumberHouse2.Size = new System.Drawing.Size(128, 21);
            this.comboBoxNumberHouse2.TabIndex = 29;
            this.comboBoxNumberHouse2.SelectedValueChanged += new System.EventHandler(this.comboBoxNumberHouse2_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Номер квартиры:";
            // 
            // FormPeoples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAverageLivingSpace);
            this.Controls.Add(this.buttonSelectByCountPeople);
            this.Controls.Add(this.buttonSelectByHouseNumber);
            this.Controls.Add(this.buttonSerchByFIO);
            this.Controls.Add(this.textBoxSerch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormPeoples";
            this.Text = "Список жильцов";
            this.Load += new System.EventHandler(this.FormPeoples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxSerch;
        private System.Windows.Forms.Button buttonSerchByFIO;
        private System.Windows.Forms.Button buttonSelectByHouseNumber;
        private System.Windows.Forms.Button buttonSelectByCountPeople;
        private System.Windows.Forms.Button buttonAverageLivingSpace;
        private System.Windows.Forms.Button buttonTradeApartment;
        private System.Windows.Forms.ComboBox comboBoxNumberHouse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNumberApartment1;
        private System.Windows.Forms.Label labelNumberApartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNumberApartment2;
        private System.Windows.Forms.ComboBox comboBoxNumberHouse2;
        private System.Windows.Forms.Label label3;
    }
}