namespace View
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonListPeople = new System.Windows.Forms.Button();
            this.buttonListPrivilege = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonListPeople
            // 
            this.buttonListPeople.Location = new System.Drawing.Point(12, 47);
            this.buttonListPeople.Name = "buttonListPeople";
            this.buttonListPeople.Size = new System.Drawing.Size(131, 41);
            this.buttonListPeople.TabIndex = 0;
            this.buttonListPeople.Text = "Работа со списком жильцов";
            this.buttonListPeople.UseVisualStyleBackColor = true;
            this.buttonListPeople.Click += new System.EventHandler(this.buttonListPeople_Click);
            // 
            // buttonListPrivilege
            // 
            this.buttonListPrivilege.Location = new System.Drawing.Point(12, 94);
            this.buttonListPrivilege.Name = "buttonListPrivilege";
            this.buttonListPrivilege.Size = new System.Drawing.Size(131, 41);
            this.buttonListPrivilege.TabIndex = 1;
            this.buttonListPrivilege.Text = "Работа со списком льгот";
            this.buttonListPrivilege.UseVisualStyleBackColor = true;
            this.buttonListPrivilege.Click += new System.EventHandler(this.buttonListPrivilege_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(12, 141);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(131, 50);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Отчеты по деятельности пасспортиста";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 231);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonListPrivilege);
            this.Controls.Add(this.buttonListPeople);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListPeople;
        private System.Windows.Forms.Button buttonListPrivilege;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
    }
}

