namespace WindowsFormsApp
{
    partial class FormMain
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
            this.buttonControlListBox = new System.Windows.Forms.Button();
            this.buttonControlTextBox = new System.Windows.Forms.Button();
            this.buttonControlDataGridView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonControlListBox
            // 
            this.buttonControlListBox.Location = new System.Drawing.Point(22, 22);
            this.buttonControlListBox.Name = "buttonControlListBox";
            this.buttonControlListBox.Size = new System.Drawing.Size(117, 24);
            this.buttonControlListBox.TabIndex = 0;
            this.buttonControlListBox.Text = "ControlListBox";
            this.buttonControlListBox.UseVisualStyleBackColor = true;
            this.buttonControlListBox.Click += new System.EventHandler(this.buttonControlListBox_Click);
            // 
            // buttonControlTextBox
            // 
            this.buttonControlTextBox.Location = new System.Drawing.Point(22, 66);
            this.buttonControlTextBox.Name = "buttonControlTextBox";
            this.buttonControlTextBox.Size = new System.Drawing.Size(117, 24);
            this.buttonControlTextBox.TabIndex = 1;
            this.buttonControlTextBox.Text = "ControlTextBox";
            this.buttonControlTextBox.UseVisualStyleBackColor = true;
            this.buttonControlTextBox.Click += new System.EventHandler(this.buttonControlTextBox_Click);
            // 
            // buttonControlDataGridView
            // 
            this.buttonControlDataGridView.Location = new System.Drawing.Point(22, 113);
            this.buttonControlDataGridView.Name = "buttonControlDataGridView";
            this.buttonControlDataGridView.Size = new System.Drawing.Size(117, 23);
            this.buttonControlDataGridView.TabIndex = 2;
            this.buttonControlDataGridView.Text = "ControlDataGridView";
            this.buttonControlDataGridView.UseVisualStyleBackColor = true;
            this.buttonControlDataGridView.Click += new System.EventHandler(this.buttonControlDataGridView_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 182);
            this.Controls.Add(this.buttonControlDataGridView);
            this.Controls.Add(this.buttonControlListBox);
            this.Controls.Add(this.buttonControlTextBox);
            this.Name = "FormMain";
            this.Text = "FormMain1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonControlListBox;
        private System.Windows.Forms.Button buttonControlTextBox;
        private System.Windows.Forms.Button buttonControlDataGridView;
    }
}