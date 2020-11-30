using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

//Олесов Максим

/*1. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
г) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
д) Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).*/

namespace Lesson8Homework
{
    public partial class Form2Task1QuestionsDataBaseEditor : Form
    {
        TrueFalse database;
        Regex regex = new Regex(@"[A-Za-z0-9А-Яа-я]+\.{0,1}\w+$"); //Шаблон, используемый для выделения имени файла для дальнейшего отображения
        public Form2Task1QuestionsDataBaseEditor()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miSave_Click(object sender, EventArgs e)
        {
                if (database != null) database.Save();
                else MessageBox.Show("База данных не создана");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            if (MessageBox.Show("Вы точно хотите удалить вопрос?", "Удалить вопрос?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                database.Remove((int)nudNumber.Value-1);
                nudNumber.Maximum--;
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                lblDataBase.Text = regex.Match(sfd.FileName).ToString();
            };
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                if (database.Load())
                {
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                    lblDataBase.Text = regex.Match(ofd.FileName).ToString();
                }
            }
        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        private void miSaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (database != null)
                {
                    database.FileName = sfd.FileName;
                    database.Save();
                    lblDataBase.Text = regex.Match(sfd.FileName).ToString();
                }
                else MessageBox.Show("База данных не создана");
            };
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database != null)
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
        }

        private void miAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}
