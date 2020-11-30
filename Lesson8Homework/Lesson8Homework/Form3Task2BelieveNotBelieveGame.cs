using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace Lesson8Homework
{
    public partial class Form3Task2BelieveNotBelieveGame : Form
    {
        TrueFalse database;
        Regex regex = new Regex(@"[A-Za-z0-9А-Яа-я]+\.{0,1}\w+$");

        TrueFalse questions; //Список вопросов выбранных для игры
        int currQestion; //Переменная для учета текущего вопроса, отображаемого игроку
        int scoreCount; //Переменная для подсчета очков
        int gameLength = 5; //Переменная отвечающая за количество вопросов, участвующих в игре

        public Form3Task2BelieveNotBelieveGame()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void miLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                if (database.Load())
                {
                    lblDataBase.Text = regex.Match(ofd.FileName).ToString();
                    tboxQuestion.Text = "База данных успешно загружена. Нахмите кнопку \"Начать\" для начала игры";
                    btnStart.Visible = true;
                    btnBelieve.Visible = false;
                    btnNotBelieve.Visible = false;
                    btnStart.Text = "Начать";
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            questions = new TrueFalse("");
            Random rnd = new Random();
            for (int i = 0; i < gameLength; i++)
            {
                int questNum = rnd.Next(database.Count);
                questions.Add(database[questNum].Text, database[questNum].TrueFalse);
            }
            scoreCount = 0;
            currQestion = 0;
            tboxQuestion.Text = questions[currQestion].Text;
            btnBelieve.Visible = true;
            btnNotBelieve.Visible = true;
            btnStart.Text = "Заново";
        }

        private void btnBelieve_Click(object sender, EventArgs e)
        {
            if (questions[currQestion].TrueFalse)
                scoreCount++;
            currQestion++;
            if (currQestion < gameLength)
            {
              tboxQuestion.Text = questions[currQestion].Text;
            }
            else
            {
                btnBelieve.Visible = false;
                btnNotBelieve.Visible = false;
                tboxQuestion.Text = $"Количество правильных ответов: {scoreCount}";
            }
        }

        private void btnNotBelieve_Click(object sender, EventArgs e)
        {
            if (!questions[currQestion].TrueFalse)
                scoreCount++;
            currQestion++;
            if (currQestion < gameLength)
            {
                tboxQuestion.Text = questions[currQestion].Text;
            }
            else
            {
                btnBelieve.Visible = false;
                btnNotBelieve.Visible = false;
                tboxQuestion.Text = $"Количество правильных ответов: {scoreCount}";
            }
        }
    }
}
