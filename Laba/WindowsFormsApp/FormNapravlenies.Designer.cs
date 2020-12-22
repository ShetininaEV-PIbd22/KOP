namespace WindowsFormsApp
{
    partial class FormNapravlenies
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonSave = new System.Windows.Forms.Button();
            this.controlListBox = new ControlLibrary.ControlListBox();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(390, 413);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 25);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // controlListBox
            // 
            this.controlListBox.Location = new System.Drawing.Point(12, 27);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.SelectedIndex = -1;
            this.controlListBox.SelectedText = "";
            this.controlListBox.Size = new System.Drawing.Size(660, 343);
            this.controlListBox.TabIndex = 1;
            // 
            // FormNapravlenies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.controlListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNapravlenies";
            this.Text = "FormNapravlenies";
            this.Load += new System.EventHandler(this.FormNapravlenies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ControlLibrary.ControlListBox controlListBox;
        private System.Windows.Forms.Button buttonSave;
    }
}