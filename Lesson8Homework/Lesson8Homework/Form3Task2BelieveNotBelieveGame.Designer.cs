namespace Lesson8Homework
{
    partial class Form3Task2BelieveNotBelieveGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3Task2BelieveNotBelieveGame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tboxQuestion = new System.Windows.Forms.TextBox();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.btnBelieve = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNotBelieve = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMenuToolStripMenuItem,
            this.miAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miMenuToolStripMenuItem
            // 
            this.miMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLoad,
            this.toolStripSeparator1,
            this.miExit});
            this.miMenuToolStripMenuItem.Name = "miMenuToolStripMenuItem";
            this.miMenuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.miMenuToolStripMenuItem.Text = "Меню";
            // 
            // miLoad
            // 
            this.miLoad.Name = "miLoad";
            this.miLoad.Size = new System.Drawing.Size(199, 22);
            this.miLoad.Text = "Загрузить базу данных";
            this.miLoad.Click += new System.EventHandler(this.miLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(199, 22);
            this.miExit.Text = "Выход";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(94, 20);
            this.miAbout.Text = "О программе";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // tboxQuestion
            // 
            this.tboxQuestion.Location = new System.Drawing.Point(10, 51);
            this.tboxQuestion.Multiline = true;
            this.tboxQuestion.Name = "tboxQuestion";
            this.tboxQuestion.ReadOnly = true;
            this.tboxQuestion.Size = new System.Drawing.Size(507, 201);
            this.tboxQuestion.TabIndex = 1;
            this.tboxQuestion.Text = resources.GetString("tboxQuestion.Text");
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Location = new System.Drawing.Point(13, 32);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(10, 13);
            this.lblDataBase.TabIndex = 2;
            this.lblDataBase.Text = " ";
            // 
            // btnBelieve
            // 
            this.btnBelieve.Location = new System.Drawing.Point(147, 258);
            this.btnBelieve.Name = "btnBelieve";
            this.btnBelieve.Size = new System.Drawing.Size(75, 23);
            this.btnBelieve.TabIndex = 3;
            this.btnBelieve.Text = "Верю";
            this.btnBelieve.UseVisualStyleBackColor = true;
            this.btnBelieve.Visible = false;
            this.btnBelieve.Click += new System.EventHandler(this.btnBelieve_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(229, 258);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNotBelieve
            // 
            this.btnNotBelieve.Location = new System.Drawing.Point(311, 258);
            this.btnNotBelieve.Name = "btnNotBelieve";
            this.btnNotBelieve.Size = new System.Drawing.Size(75, 23);
            this.btnNotBelieve.TabIndex = 5;
            this.btnNotBelieve.Text = "Не верю";
            this.btnNotBelieve.UseVisualStyleBackColor = true;
            this.btnNotBelieve.Visible = false;
            this.btnNotBelieve.Click += new System.EventHandler(this.btnNotBelieve_Click);
            // 
            // Form3Task2BelieveNotBelieveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 299);
            this.Controls.Add(this.btnNotBelieve);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBelieve);
            this.Controls.Add(this.lblDataBase);
            this.Controls.Add(this.tboxQuestion);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3Task2BelieveNotBelieveGame";
            this.Text = "Игра \"Верю - Не верю\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.TextBox tboxQuestion;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Button btnBelieve;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNotBelieve;
    }
}