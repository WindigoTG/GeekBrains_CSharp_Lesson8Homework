using System;
using System.Windows.Forms;

namespace Lesson8Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2Task1QuestionsDataBaseEditor form2 = new Form2Task1QuestionsDataBaseEditor();
            form2.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBelieveNotBelieve_Click(object sender, EventArgs e)
        {
            Form3Task2BelieveNotBelieveGame form3 = new Form3Task2BelieveNotBelieveGame();
            form3.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void btnStudentsConverter_Click(object sender, EventArgs e)
        {
            Form4Task3StudentsInfo form4 = new Form4Task3StudentsInfo();
            form4.ShowDialog();
        }
    }
}
