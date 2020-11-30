using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lesson8Homework
{
    class TrueFalse
    {
        string fileName;
        List<Question> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        public Question this[int index]
        {
            get { return list[index]; }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public bool Load()
        {
            try
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
                Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                list = (List<Question>)xmlFormat.Deserialize(fStream);
                fStream.Close();
                return true;
            }
            catch
            {
                MessageBox.Show("Неверный файл");
                return false;
            }
        }
        public int Count
        {
            get { return list.Count; }
        }
    }

}
