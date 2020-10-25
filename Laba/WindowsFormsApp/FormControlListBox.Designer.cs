namespace WindowsFormsApp
{
    partial class FormControlListBox
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.controlListBox = new ControlLibrary.ControlListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(689, 82);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(81, 63);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Изменить данные студента";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(689, 165);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(81, 78);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "Получить данные выбранного студента";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // controlListBox
            // 
            this.controlListBox.Location = new System.Drawing.Point(12, 3);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.SelectedIndex = -1;
            this.controlListBox.SelectedText = "";
            this.controlListBox.Size = new System.Drawing.Size(660, 345);
            this.controlListBox.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(689, 27);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 39);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить студента";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormControlListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.controlListBox);
            this.Name = "FormControlListBox";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.ControlListBox controlListBox;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonAdd;
    }
}