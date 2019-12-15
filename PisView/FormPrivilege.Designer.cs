namespace View
{
    partial class FormPrivilege
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxMultiplier = new System.Windows.Forms.TextBox();
            this.comboBoxTypePrivilege = new System.Windows.Forms.ComboBox();
            this.textBoxNamePrivilege = new System.Windows.Forms.TextBox();
            this.labelNamePrivilege = new System.Windows.Forms.Label();
            this.labelTypePrivilege = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(426, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(546, 92);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 27);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(546, 125);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 27);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(546, 158);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 27);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxMultiplier
            // 
            this.textBoxMultiplier.Location = new System.Drawing.Point(546, 66);
            this.textBoxMultiplier.Name = "textBoxMultiplier";
            this.textBoxMultiplier.Size = new System.Drawing.Size(121, 20);
            this.textBoxMultiplier.TabIndex = 4;
            // 
            // comboBoxTypePrivilege
            // 
            this.comboBoxTypePrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypePrivilege.FormattingEnabled = true;
            this.comboBoxTypePrivilege.Items.AddRange(new object[] {
            "На газ",
            "На электричесво",
            "На воду",
            "На общедомовые нужды"});
            this.comboBoxTypePrivilege.Location = new System.Drawing.Point(546, 39);
            this.comboBoxTypePrivilege.Name = "comboBoxTypePrivilege";
            this.comboBoxTypePrivilege.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypePrivilege.TabIndex = 5;
            // 
            // textBoxNamePrivilege
            // 
            this.textBoxNamePrivilege.Location = new System.Drawing.Point(546, 13);
            this.textBoxNamePrivilege.Name = "textBoxNamePrivilege";
            this.textBoxNamePrivilege.Size = new System.Drawing.Size(121, 20);
            this.textBoxNamePrivilege.TabIndex = 6;
            // 
            // labelNamePrivilege
            // 
            this.labelNamePrivilege.AutoSize = true;
            this.labelNamePrivilege.Location = new System.Drawing.Point(444, 16);
            this.labelNamePrivilege.Name = "labelNamePrivilege";
            this.labelNamePrivilege.Size = new System.Drawing.Size(99, 13);
            this.labelNamePrivilege.TabIndex = 7;
            this.labelNamePrivilege.Text = "Название льготы:";
            // 
            // labelTypePrivilege
            // 
            this.labelTypePrivilege.AutoSize = true;
            this.labelTypePrivilege.Location = new System.Drawing.Point(444, 42);
            this.labelTypePrivilege.Name = "labelTypePrivilege";
            this.labelTypePrivilege.Size = new System.Drawing.Size(68, 13);
            this.labelTypePrivilege.TabIndex = 8;
            this.labelTypePrivilege.Text = "Тип льготы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Коэффициент:";
            // 
            // FormPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTypePrivilege);
            this.Controls.Add(this.labelNamePrivilege);
            this.Controls.Add(this.textBoxNamePrivilege);
            this.Controls.Add(this.comboBoxTypePrivilege);
            this.Controls.Add(this.textBoxMultiplier);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPrivilege";
            this.Text = "Льготы";
            this.Load += new System.EventHandler(this.FormPrivilege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxMultiplier;
        private System.Windows.Forms.ComboBox comboBoxTypePrivilege;
        private System.Windows.Forms.TextBox textBoxNamePrivilege;
        private System.Windows.Forms.Label labelNamePrivilege;
        private System.Windows.Forms.Label labelTypePrivilege;
        private System.Windows.Forms.Label label1;
    }
}