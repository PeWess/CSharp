using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSVtoXML
{
    class Program
    {
        public class Student
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Grade { get; set; }
            public int ExamPoints { get; set; }
        }

        static void Main(string[] args)
        {
            //Программу написал Сергей Критский
            Console.WriteLine("Задание 3. Программа конвертирует CSV файл в XML файл.");

            string filename = AppDomain.CurrentDomain.BaseDirectory + "StudentsFromCSV.csv";
            string err = "";

            if (File.Exists(filename) == false)
            {
                Console.WriteLine("Указанного файла не существует");
                Console.ReadKey();
                return;
            }

            string[] CSVData = File.ReadAllLines(filename, Encoding.GetEncoding(1251));
            List<Student> students = new List<Student>();

            for (int i = 1; i < CSVData.Length; i++)
            {
                var studentData = CSVData[i].Split(',');
                try
                {
                    Student student = new Student()
                    {
                        Surname = studentData[0],
                        Name = studentData[1],
                        Age = int.Parse(studentData[2]),
                        Grade = int.Parse(studentData[3]),
                        ExamPoints = int.Parse(studentData[4])
                    };
                    students.Add(student);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Данные в файле указаны некорректно: строка {i + 1}");
                    Console.WriteLine($"\nКонвертация не может быть завершена.");
                    Console.ReadKey();
                    return;
                }
            }

            XElement XMLData = new XElement("Students_List",
                    students.Select(s =>
                      new XElement("Student",
                          new XElement("Surname", s.Surname),
                          new XElement("Name", s.Name),
                          new XElement("Age", s.Age),
                          new XElement("Grade", s.Grade),
                          new XElement("ExamPoints", s.ExamPoints)
                       )
                    )
                );
            XMLData.Save(AppDomain.CurrentDomain.BaseDirectory + "StudentsToXML.xml");

            Console.WriteLine($"\nКонвертация завершена. Файл находится в {AppDomain.CurrentDomain.BaseDirectory + "StudentsToXML.xml"}");
            Console.ReadKey();
        }
    }
}