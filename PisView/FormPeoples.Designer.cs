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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 32);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(495, 316);
            this.dataGridView.TabIndex = 15;
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(511, 308);
            this.buttonUpd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(112, 36);
            this.buttonUpd.TabIndex = 14;
            this.buttonUpd.Text = "Обновить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(511, 258);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(112, 36);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(511, 207);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(112, 35);
            this.buttonChange.TabIndex = 12;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(511, 152);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 35);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Диаграмма распределения жильцов по квартирам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(699, 7);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "NumberHouse";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(395, 300);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // FormPeoples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 365);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}