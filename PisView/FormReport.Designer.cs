namespace View
{
    partial class FormReport
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPrivilegeApart = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCountPeopleInApart = new System.Windows.Forms.Button();
            this.buttonDiagram = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labe1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFamily = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(577, 45);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "NumberHouse";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(395, 300);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // buttonPrivilegeApart
            // 
            this.buttonPrivilegeApart.Location = new System.Drawing.Point(588, 355);
            this.buttonPrivilegeApart.Name = "buttonPrivilegeApart";
            this.buttonPrivilegeApart.Size = new System.Drawing.Size(395, 24);
            this.buttonPrivilegeApart.TabIndex = 23;
            this.buttonPrivilegeApart.Text = "Распределение льготников по кв( перекрестный)";
            this.buttonPrivilegeApart.UseVisualStyleBackColor = true;
            this.buttonPrivilegeApart.Click += new System.EventHandler(this.buttonPrivilegeApart_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 45);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(545, 381);
            this.dataGridView.TabIndex = 25;
            // 
            // buttonCountPeopleInApart
            // 
            this.buttonCountPeopleInApart.Location = new System.Drawing.Point(588, 385);
            this.buttonCountPeopleInApart.Name = "buttonCountPeopleInApart";
            this.buttonCountPeopleInApart.Size = new System.Drawing.Size(395, 24);
            this.buttonCountPeopleInApart.TabIndex = 26;
            this.buttonCountPeopleInApart.Text = "Поквартирный список с кол-во жильцов";
            this.buttonCountPeopleInApart.UseVisualStyleBackColor = true;
            this.buttonCountPeopleInApart.Click += new System.EventHandler(this.buttonCountPeopleInApart_Click);
            // 
            // buttonDiagram
            // 
            this.buttonDiagram.Location = new System.Drawing.Point(588, 415);
            this.buttonDiagram.Name = "buttonDiagram";
            this.buttonDiagram.Size = new System.Drawing.Size(395, 24);
            this.buttonDiagram.TabIndex = 27;
            this.buttonDiagram.Text = "Диаграмма распределения жильцов по квартирам";
            this.buttonDiagram.UseVisualStyleBackColor = true;
            this.buttonDiagram.Click += new System.EventHandler(this.buttonDiagram_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(376, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(607, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(582, 18);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(19, 13);
            this.labe1.TabIndex = 30;
            this.labe1.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "С";
            // 
            // buttonFamily
            // 
            this.buttonFamily.Location = new System.Drawing.Point(588, 445);
            this.buttonFamily.Name = "buttonFamily";
            this.buttonFamily.Size = new System.Drawing.Size(395, 24);
            this.buttonFamily.TabIndex = 32;
            this.buttonFamily.Text = "Справка о составе семьи";
            this.buttonFamily.UseVisualStyleBackColor = true;
            this.buttonFamily.Click += new System.EventHandler(this.buttonFamily_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 20);
            this.textBox1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(354, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 34;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonFamily);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonDiagram);
            this.Controls.Add(this.buttonCountPeopleInApart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonPrivilegeApart);
            this.Name = "FormReport";
            this.Text = "Отчеты пасспортиста";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonPrivilegeApart;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCountPeopleInApart;
        private System.Windows.Forms.Button buttonDiagram;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFamily;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}