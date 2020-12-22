namespace WindowsFormsApp
{
    partial class FormStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCensel = new System.Windows.Forms.Button();
            this.dateControl = new ControlLibrary.DateControl();
            this.checkBoxControl = new ControlLibrary.CheckBoxControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО студента:";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(113, 26);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(440, 20);
            this.textBoxFIO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата поступления:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(597, 367);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCensel
            // 
            this.buttonCensel.Location = new System.Drawing.Point(596, 408);
            this.buttonCensel.Name = "buttonCensel";
            this.buttonCensel.Size = new System.Drawing.Size(75, 23);
            this.buttonCensel.TabIndex = 7;
            this.buttonCensel.Text = "Отмена";
            this.buttonCensel.UseVisualStyleBackColor = true;
            this.buttonCensel.Click += new System.EventHandler(this.buttonCensel_Click);
            // 
            // dateControl
            // 
            this.dateControl.Location = new System.Drawing.Point(113, 55);
            this.dateControl.Name = "dateControl";
            this.dateControl.Size = new System.Drawing.Size(311, 53);
            this.dateControl.TabIndex = 8;
            // 
            // checkBoxControl
            // 
            this.checkBoxControl.Location = new System.Drawing.Point(12, 104);
            this.checkBoxControl.Name = "checkBoxControl";
            this.checkBoxControl.SelectedIndex = null;
            this.checkBoxControl.SelectedText = new string[0];
            this.checkBoxControl.Size = new System.Drawing.Size(555, 341);
            this.checkBoxControl.TabIndex = 9;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 457);
            this.Controls.Add(this.checkBoxControl);
            this.Controls.Add(this.dateControl);
            this.Controls.Add(this.buttonCensel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label1);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCensel;
        private ControlLibrary.DateControl dateControl;
        private ControlLibrary.CheckBoxControl checkBoxControl;
    }
}