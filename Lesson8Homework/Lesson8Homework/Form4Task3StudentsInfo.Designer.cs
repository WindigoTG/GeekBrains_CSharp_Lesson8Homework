namespace Lesson8Homework
{
    partial class Form4Task3StudentsInfo
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenCVS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAsXML = new System.Windows.Forms.Button();
            this.btnSaveAsCVS = new System.Windows.Forms.Button();
            this.miOpenXML = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 41);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(766, 262);
            this.dgvStudents.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMenuToolStripMenuItem,
            this.miAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miMenuToolStripMenuItem
            // 
            this.miMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenCVS,
            this.miOpenXML,
            this.toolStripSeparator1,
            this.miExit});
            this.miMenuToolStripMenuItem.Name = "miMenuToolStripMenuItem";
            this.miMenuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.miMenuToolStripMenuItem.Text = "Меню";
            // 
            // miOpenCVS
            // 
            this.miOpenCVS.Name = "miOpenCVS";
            this.miOpenCVS.Size = new System.Drawing.Size(243, 22);
            this.miOpenCVS.Text = "Открыть CVS файл с данными";
            this.miOpenCVS.Click += new System.EventHandler(this.miOpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(243, 22);
            this.miExit.Text = "Выход";
            this.miExit.Click += new System.EventHandler(this.miExitToolStripMenuItem_Click);
            // 
            // btnSaveAsXML
            // 
            this.btnSaveAsXML.Location = new System.Drawing.Point(13, 310);
            this.btnSaveAsXML.Name = "btnSaveAsXML";
            this.btnSaveAsXML.Size = new System.Drawing.Size(178, 23);
            this.btnSaveAsXML.TabIndex = 2;
            this.btnSaveAsXML.Text = "Сохранить в XML формате";
            this.btnSaveAsXML.UseVisualStyleBackColor = true;
            this.btnSaveAsXML.Click += new System.EventHandler(this.btnSaveAsXML_Click);
            // 
            // btnSaveAsCVS
            // 
            this.btnSaveAsCVS.Location = new System.Drawing.Point(600, 310);
            this.btnSaveAsCVS.Name = "btnSaveAsCVS";
            this.btnSaveAsCVS.Size = new System.Drawing.Size(178, 23);
            this.btnSaveAsCVS.TabIndex = 3;
            this.btnSaveAsCVS.Text = "Сохранить в CVS формате";
            this.btnSaveAsCVS.UseVisualStyleBackColor = true;
            this.btnSaveAsCVS.Click += new System.EventHandler(this.btnSaveAsCVS_Click);
            // 
            // miOpenXML
            // 
            this.miOpenXML.Name = "miOpenXML";
            this.miOpenXML.Size = new System.Drawing.Size(243, 22);
            this.miOpenXML.Text = "Открыть XML файл с данными";
            this.miOpenXML.Click += new System.EventHandler(this.miOpenXMLToolStripMenuItem_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(94, 20);
            this.miAbout.Text = "О программе";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // Form4Task3StudentsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 348);
            this.Controls.Add(this.btnSaveAsCVS);
            this.Controls.Add(this.btnSaveAsXML);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4Task3StudentsInfo";
            this.Text = "Информация о студентах";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpenCVS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.Button btnSaveAsXML;
        private System.Windows.Forms.Button btnSaveAsCVS;
        private System.Windows.Forms.ToolStripMenuItem miOpenXML;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
    }
}