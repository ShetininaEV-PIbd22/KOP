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
            this.buttonFormStore = new System.Windows.Forms.Button();
            this.buttonFormWord = new System.Windows.Forms.Button();
            this.buttonFormExcel = new System.Windows.Forms.Button();
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
            // buttonFormStore
            // 
            this.buttonFormStore.Location = new System.Drawing.Point(205, 22);
            this.buttonFormStore.Name = "buttonFormStore";
            this.buttonFormStore.Size = new System.Drawing.Size(103, 23);
            this.buttonFormStore.TabIndex = 3;
            this.buttonFormStore.Text = "FormStore";
            this.buttonFormStore.UseVisualStyleBackColor = true;
            this.buttonFormStore.Click += new System.EventHandler(this.buttonFormStore_Click);
            // 
            // buttonFormWord
            // 
            this.buttonFormWord.Location = new System.Drawing.Point(205, 66);
            this.buttonFormWord.Name = "buttonFormWord";
            this.buttonFormWord.Size = new System.Drawing.Size(103, 23);
            this.buttonFormWord.TabIndex = 4;
            this.buttonFormWord.Text = "FormWord";
            this.buttonFormWord.UseVisualStyleBackColor = true;
            this.buttonFormWord.Click += new System.EventHandler(this.buttonFormWord_Click);
            // 
            // buttonFormExcel
            // 
            this.buttonFormExcel.Location = new System.Drawing.Point(205, 112);
            this.buttonFormExcel.Name = "buttonFormExcel";
            this.buttonFormExcel.Size = new System.Drawing.Size(103, 23);
            this.buttonFormExcel.TabIndex = 5;
            this.buttonFormExcel.Text = "FormExcel";
            this.buttonFormExcel.UseVisualStyleBackColor = true;
            this.buttonFormExcel.Click += new System.EventHandler(this.buttonFormExcel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 188);
            this.Controls.Add(this.buttonFormExcel);
            this.Controls.Add(this.buttonFormWord);
            this.Controls.Add(this.buttonFormStore);
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
        private System.Windows.Forms.Button buttonFormStore;
        private System.Windows.Forms.Button buttonFormWord;
        private System.Windows.Forms.Button buttonFormExcel;
    }
}