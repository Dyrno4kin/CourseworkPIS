namespace View
{
    partial class FormPeoplePrivilege
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
            this.comboBoxPrivilege = new System.Windows.Forms.ComboBox();
            this.labelPrivilege = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(165, 67);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 31);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(20, 67);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 31);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxPrivilege
            // 
            this.comboBoxPrivilege.FormattingEnabled = true;
            this.comboBoxPrivilege.Location = new System.Drawing.Point(102, 22);
            this.comboBoxPrivilege.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPrivilege.Name = "comboBoxPrivilege";
            this.comboBoxPrivilege.Size = new System.Drawing.Size(128, 21);
            this.comboBoxPrivilege.TabIndex = 9;
            // 
            // labelPrivilege
            // 
            this.labelPrivilege.AutoSize = true;
            this.labelPrivilege.Location = new System.Drawing.Point(17, 24);
            this.labelPrivilege.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrivilege.Name = "labelPrivilege";
            this.labelPrivilege.Size = new System.Drawing.Size(46, 13);
            this.labelPrivilege.TabIndex = 6;
            this.labelPrivilege.Text = "Льгота:";
            // 
            // FormPeoplePrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 110);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxPrivilege);
            this.Controls.Add(this.labelPrivilege);
            this.Name = "FormPeoplePrivilege";
            this.Text = "FormPeoplePrivilege";
            this.Load += new System.EventHandler(this.FormPeoplePrivilege_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxPrivilege;
        private System.Windows.Forms.Label labelPrivilege;
    }
}