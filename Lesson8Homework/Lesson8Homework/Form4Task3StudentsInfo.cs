using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

//Олесов Максим

//3. * Написать программу - преобразователь из CSV в XML-файл с информацией о студентах (6 урок).

namespace Lesson8Homework
{
    public partial class Form4Task3StudentsInfo : Form
    {
        List<Student> studentsDataBase;
        public Form4Task3StudentsInfo()
        {
            InitializeComponent();
        }

        private void miExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CVS files (*.cvs)|*.cvs|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    studentsDataBase = new List<Student>();
                    string[] data = File.ReadAllLines(ofd.FileName);
                    foreach (string str in data)
                    {
                        string[] dataString = str.Split(';');
                        studentsDataBase.Add(new Student(dataString[0], dataString[1], dataString[2], dataString[3], int.Parse(dataString[4]), int.Parse(dataString[5]), dataString[6]));
                    }

                    DisplayDataBase();
                    MessageBox.Show("CVS файл успешно открыт", "Успех");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Вероятно данные в файле имеют неверный формат", "Ошибка");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void btnSaveAsXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                xml.Serialize(fs, studentsDataBase);
                fs.Close();
                MessageBox.Show("XML файл успешно сохранён", "Успех");
            }
        }

        private void DisplayDataBase()
        {
            DataTable dt = new DataTable("Студенты");
            DataColumn colFirstName = new DataColumn("Имя", typeof(string));
            DataColumn colLastName = new DataColumn("Фамилия", typeof(string));
            DataColumn colUniversity = new DataColumn("Университет", typeof(string));
            DataColumn colFaculty = new DataColumn("Факультет", typeof(string));
            DataColumn colAge = new DataColumn("Возраст", typeof(int));
            DataColumn colCourse = new DataColumn("Курс", typeof(int));
            DataColumn colCity = new DataColumn("Город", typeof(string));
            dt.Columns.AddRange(new DataColumn[] { colFirstName, colLastName, colUniversity, colFaculty, colAge, colCourse, colCity });
            DataRow dr = null;
            foreach (Student stud in studentsDataBase)
            {
                dr = dt.NewRow();
                dr["Имя"] = stud.firstName;
                dr["Фамилия"] = stud.lastName;
                dr["Университет"] = stud.university;
                dr["Факультет"] = stud.faculty;
                dr["Возраст"] = stud.age;
                dr["Курс"] = stud.course;
                dr["Город"] = stud.city;
                dt.Rows.Add(dr);
            }
            dgvStudents.DataSource = dt;
        }

        private void miOpenXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    studentsDataBase = (List<Student>)xml.Deserialize(fs);
                    fs.Close();

                    DisplayDataBase();
                    MessageBox.Show("XML файл успешно открыт", "Успех");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Вероятно данные в файле имеют неверный формат", "Ошибка");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void btnSaveAsCVS_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CVS files (*.cvs)|*.cvs|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (Student stud in studentsDataBase)
                    sw.WriteLine($"{stud.firstName};{stud.lastName};{stud.university};{stud.faculty};{stud.age};{stud.course};{stud.city}");
                sw.Close();
                MessageBox.Show("CVS файл успешно сохранён","Успех");
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}
