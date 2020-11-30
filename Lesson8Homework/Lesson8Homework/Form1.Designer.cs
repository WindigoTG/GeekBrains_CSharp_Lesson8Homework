namespace Lesson8Homework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuestionsEditor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBelieveNotBelieve = new System.Windows.Forms.Button();
            this.btnStudentsConverter = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestionsEditor
            // 
            this.btnQuestionsEditor.Location = new System.Drawing.Point(12, 12);
            this.btnQuestionsEditor.Name = "btnQuestionsEditor";
            this.btnQuestionsEditor.Size = new System.Drawing.Size(204, 23);
            this.btnQuestionsEditor.TabIndex = 0;
            this.btnQuestionsEditor.Text = "Редактор базы данных с вопросами";
            this.btnQuestionsEditor.UseVisualStyleBackColor = true;
            this.btnQuestionsEditor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 128);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBelieveNotBelieve
            // 
            this.btnBelieveNotBelieve.Location = new System.Drawing.Point(12, 41);
            this.btnBelieveNotBelieve.Name = "btnBelieveNotBelieve";
            this.btnBelieveNotBelieve.Size = new System.Drawing.Size(204, 23);
            this.btnBelieveNotBelieve.TabIndex = 2;
            this.btnBelieveNotBelieve.Text = "Игра \"Верю - Не верю\"";
            this.btnBelieveNotBelieve.UseVisualStyleBackColor = true;
            this.btnBelieveNotBelieve.Click += new System.EventHandler(this.btnBelieveNotBelieve_Click);
            // 
            // btnStudentsConverter
            // 
            this.btnStudentsConverter.Location = new System.Drawing.Point(12, 70);
            this.btnStudentsConverter.Name = "btnStudentsConverter";
            this.btnStudentsConverter.Size = new System.Drawing.Size(204, 23);
            this.btnStudentsConverter.TabIndex = 3;
            this.btnStudentsConverter.Text = "Конвертер информации о студентах";
            this.btnStudentsConverter.UseVisualStyleBackColor = true;
            this.btnStudentsConverter.Click += new System.EventHandler(this.btnStudentsConverter_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 99);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(204, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "О программе";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(227, 162);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStudentsConverter);
            this.Controls.Add(this.btnBelieveNotBelieve);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuestionsEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuestionsEditor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBelieveNotBelieve;
        private System.Windows.Forms.Button btnStudentsConverter;
        private System.Windows.Forms.Button btnAbout;
    }
}

