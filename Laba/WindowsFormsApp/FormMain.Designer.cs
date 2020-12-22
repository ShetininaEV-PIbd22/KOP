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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.направленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНаправлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьНToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСтудентовНаЭтомНаправленииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.controlListBox = new ControlLibrary.ControlListBox();
            this.componentStore = new ControlLibrary.Components.ComponentStore(this.components);
            this.componentPDF = new ControlLibrary.Components.ComponentPDF(this.components);
            this.componentPdfReport = new ControlLibrary.Components.ComponentPdfReport(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.направленияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // направленияToolStripMenuItem
            // 
            this.направленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНаправлениеToolStripMenuItem,
            this.изменитьНToolStripMenuItem,
            this.списокСтудентовНаЭтомНаправленииToolStripMenuItem,
            this.сохранитьДанныеToolStripMenuItem1});
            this.направленияToolStripMenuItem.Name = "направленияToolStripMenuItem";
            this.направленияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.направленияToolStripMenuItem.Text = "Направления";
            // 
            // добавитьНаправлениеToolStripMenuItem
            // 
            this.добавитьНаправлениеToolStripMenuItem.Name = "добавитьНаправлениеToolStripMenuItem";
            this.добавитьНаправлениеToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.добавитьНаправлениеToolStripMenuItem.Text = "Добавить направление";
            this.добавитьНаправлениеToolStripMenuItem.Click += new System.EventHandler(this.добавитьНаправлениеToolStripMenuItem_Click);
            // 
            // изменитьНToolStripMenuItem
            // 
            this.изменитьНToolStripMenuItem.Name = "изменитьНToolStripMenuItem";
            this.изменитьНToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.изменитьНToolStripMenuItem.Text = "Изменить название направления";
            this.изменитьНToolStripMenuItem.Click += new System.EventHandler(this.изменитьНToolStripMenuItem_Click);
            // 
            // списокСтудентовНаЭтомНаправленииToolStripMenuItem
            // 
            this.списокСтудентовНаЭтомНаправленииToolStripMenuItem.Name = "списокСтудентовНаЭтомНаправленииToolStripMenuItem";
            this.списокСтудентовНаЭтомНаправленииToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.списокСтудентовНаЭтомНаправленииToolStripMenuItem.Text = "Список студентов на этом направлении";
            this.списокСтудентовНаЭтомНаправленииToolStripMenuItem.Click += new System.EventHandler(this.списокСтудентовНаЭтомНаправленииToolStripMenuItem_Click);
            // 
            // сохранитьДанныеToolStripMenuItem1
            // 
            this.сохранитьДанныеToolStripMenuItem1.Name = "сохранитьДанныеToolStripMenuItem1";
            this.сохранитьДанныеToolStripMenuItem1.Size = new System.Drawing.Size(294, 22);
            this.сохранитьДанныеToolStripMenuItem1.Text = "Сохранить данные";
            this.сохранитьДанныеToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьДанныеToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(234, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список всех направлений:";
            // 
            // controlListBox
            // 
            this.controlListBox.Location = new System.Drawing.Point(5, 54);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.SelectedIndex = -1;
            this.controlListBox.SelectedText = "";
            this.controlListBox.Size = new System.Drawing.Size(660, 335);
            this.controlListBox.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem направленияToolStripMenuItem;
        private ControlLibrary.ControlListBox controlListBox;
        private System.Windows.Forms.ToolStripMenuItem добавитьНаправлениеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem изменитьНToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСтудентовНаЭтомНаправленииToolStripMenuItem;
        private ControlLibrary.Components.ComponentStore componentStore;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеToolStripMenuItem1;
        private ControlLibrary.Components.ComponentPDF componentPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private ControlLibrary.Components.ComponentPdfReport componentPdfReport;
    }
}