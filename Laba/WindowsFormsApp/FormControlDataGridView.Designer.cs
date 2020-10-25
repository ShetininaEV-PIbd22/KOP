namespace WindowsFormsApp
{
    partial class FormControlDataGridView
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
            this.controlDataGridView = new ControlLibrary.ControlDataGridView();
            this.buttonGetIndex = new System.Windows.Forms.Button();
            this.buttonSetIndex = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlDataGridView
            // 
            this.controlDataGridView.Location = new System.Drawing.Point(12, 12);
            this.controlDataGridView.Name = "controlDataGridView";
            //this.controlDataGridView.SelectedIndex = -1;
            this.controlDataGridView.Size = new System.Drawing.Size(643, 341);
            this.controlDataGridView.TabIndex = 0;
            // 
            // buttonGetIndex
            // 
            this.buttonGetIndex.Location = new System.Drawing.Point(661, 27);
            this.buttonGetIndex.Name = "buttonGetIndex";
            this.buttonGetIndex.Size = new System.Drawing.Size(99, 76);
            this.buttonGetIndex.TabIndex = 1;
            this.buttonGetIndex.Text = "Получить индекс выбранной строки";
            this.buttonGetIndex.UseVisualStyleBackColor = true;
            this.buttonGetIndex.Click += new System.EventHandler(this.buttonGetIndex_Click);
            // 
            // buttonSetIndex
            // 
            this.buttonSetIndex.Location = new System.Drawing.Point(661, 130);
            this.buttonSetIndex.Name = "buttonSetIndex";
            this.buttonSetIndex.Size = new System.Drawing.Size(99, 82);
            this.buttonSetIndex.TabIndex = 2;
            this.buttonSetIndex.Text = "Установить индекс для выбранной строки";
            this.buttonSetIndex.UseVisualStyleBackColor = true;
            this.buttonSetIndex.Click += new System.EventHandler(this.buttonSetIndex_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(662, 236);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(98, 40);
            this.buttonRef.TabIndex = 3;
            this.buttonRef.Text = "Получить ссылку";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(662, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 31);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormControlDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRef);
            this.Controls.Add(this.buttonSetIndex);
            this.Controls.Add(this.buttonGetIndex);
            this.Controls.Add(this.controlDataGridView);
            this.Name = "FormControlDataGridView";
            this.Text = "FormControlDataGridView";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.ControlDataGridView controlDataGridView;
        private System.Windows.Forms.Button buttonGetIndex;
        private System.Windows.Forms.Button buttonSetIndex;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.Button buttonAdd;
    }
}