namespace WindowsFormsApp
{
    partial class FormNapravlenieStudents
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
            this.controlListBox = new ControlLibrary.ControlListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Направление:";
            // 
            // controlListBox
            // 
            this.controlListBox.Location = new System.Drawing.Point(12, 49);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.SelectedIndex = -1;
            this.controlListBox.SelectedText = "";
            this.controlListBox.Size = new System.Drawing.Size(660, 345);
            this.controlListBox.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(97, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(556, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // FormNapravlenieStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.controlListBox);
            this.Controls.Add(this.label1);
            this.Name = "FormNapravlenieStudents";
            this.Text = "FormNapravlenieStudents";
            this.Load += new System.EventHandler(this.FormNapravlenieStudents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ControlLibrary.ControlListBox controlListBox;
        private System.Windows.Forms.TextBox textBoxName;
    }
}