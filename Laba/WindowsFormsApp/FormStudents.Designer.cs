namespace WindowsFormsApp
{
    partial class FormStudents
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
            this.controlListBox = new ControlLibrary.ControlListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.направленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНаправлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСтудентовСНаправлениямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.componentPDF = new ControlLibrary.Components.ComponentPDF(this.components);
            this.componentPdfReport = new ControlLibrary.Components.ComponentPdfReport(this.components);
            this.componentStore = new ControlLibrary.Components.ComponentStore(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlListBox
            // 
            this.controlListBox.Location = new System.Drawing.Point(12, 76);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.SelectedIndex = -1;
            this.controlListBox.SelectedText = "";
            this.controlListBox.Size = new System.Drawing.Size(660, 362);
            this.controlListBox.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(678, 206);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 37);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить студента";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(678, 272);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(94, 83);
            this.buttonUpd.TabIndex = 2;
            this.buttonUpd.Text = "Просмотреть или изменить данные студента";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(678, 370);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(94, 35);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить студента";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(291, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список студентов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.направленияToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // направленияToolStripMenuItem
            // 
            this.направленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНаправлениеToolStripMenuItem,
            this.toolStripMenuItem1});
            this.направленияToolStripMenuItem.Name = "направленияToolStripMenuItem";
            this.направленияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.направленияToolStripMenuItem.Text = "Направления";
            // 
            // добавитьНаправлениеToolStripMenuItem
            // 
            this.добавитьНаправлениеToolStripMenuItem.Name = "добавитьНаправлениеToolStripMenuItem";
            this.добавитьНаправлениеToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.добавитьНаправлениеToolStripMenuItem.Text = "Список направлений";
            this.добавитьНаправлениеToolStripMenuItem.Click += new System.EventHandler(this.добавитьНаправлениеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem1.Text = "Сохранить данные";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьДанныеToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // сохранитьДанныеToolStripMenuItem
            // 
            this.сохранитьДанныеToolStripMenuItem.Name = "сохранитьДанныеToolStripMenuItem";
            this.сохранитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.сохранитьДанныеToolStripMenuItem.Text = "Сохранить данные";
            this.сохранитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДанныеToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСтудентовСНаправлениямиToolStripMenuItem,
            this.диаграммаToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // списокСтудентовСНаправлениямиToolStripMenuItem
            // 
            this.списокСтудентовСНаправлениямиToolStripMenuItem.Name = "списокСтудентовСНаправлениямиToolStripMenuItem";
            this.списокСтудентовСНаправлениямиToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.списокСтудентовСНаправлениямиToolStripMenuItem.Text = "Список студентов с направлениями";
            this.списокСтудентовСНаправлениямиToolStripMenuItem.Click += new System.EventHandler(this.списокСтудентовСНаправлениямиToolStripMenuItem_Click);
            // 
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.диаграммаToolStripMenuItem.Text = "Диаграмма";
            this.диаграммаToolStripMenuItem.Click += new System.EventHandler(this.диаграммаToolStripMenuItem_Click);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.controlListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudents";
            this.Text = "FormStudents";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibrary.ControlListBox controlListBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem направленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНаправлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСтудентовСНаправлениямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private ControlLibrary.Components.ComponentPDF componentPDF;
        private ControlLibrary.Components.ComponentPdfReport componentPdfReport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private ControlLibrary.Components.ComponentStore componentStore;
    }
}