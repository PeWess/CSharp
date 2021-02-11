using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    delegate double ForFunctions(double num1, double num2);
    delegate double FunctionTask2(double a);
    delegate void CountStudentsFor(int studentInfo, int searchInfo, ref int result);

    class Program
    {
        static void NextTask()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
        }

        #region Task 1

        static double Function2(double num1, double num2)
        {
            Console.Write($"{num1} * sin({num2})");
            return num1 * Math.Sin(num2 * Math.PI / 180);
        }

        static void Calculate(ForFunctions function, double num1, double num2)
        {
            var result = function(num1, num2);
            Console.WriteLine($" = {result}");
        }

        static void Task1()
        {
            Console.WriteLine("Задание 1. Дописать программу с выводом функций, добавив пару функций.\n");

            double a, x;

            Console.Write("Введите число a: ");
            if (double.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.Write("Введены некорректные данные. Попробуйте еще раз: ");
            }

            Console.Write("Введите число x: ");
            if (double.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.Write("Введены некорректные данные. Попробуйте еще раз: ");
            }

            ForFunctions function1 = delegate (double num1, double num2)
            {
                Console.Write($"{num1} * {num2}^2");
                return num1 * Math.Pow(num2, 2);
            };
            Console.WriteLine($" = {function1(a, x)}");

            Calculate(Function2, a, x);
        }


        #endregion

        #region Task 2

        #region Functions

        public static double Func1(double x)
        {
            return Math.Sin(2 * x * Math.PI / 180);
        }

        public static double Func2(double x)
        {
            return (x * 3 - 1) * 5;
        }

        public static double Func3(double x)
        {
            return Math.Cos((7 * x + 2) * Math.PI / 180);
        }

        public static double Func4(double x)
        {
            return 1 / (x * x - x);
        }

        public static double Func5(double x)
        {
            return Math.Sin(2 * x * Math.PI / 180) * Math.Sin(x * Math.PI / 180);
        }

        #endregion

        public static void SaveFunc(FunctionTask2 function, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;

            while (x <= b)
            {
                bw.Write(function(x));
                x += h;
            }

            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double[] results = new double[fs.Length / sizeof(double)];
            double tmpMin = br.ReadDouble();
            results[0] = tmpMin;

            for (int i = 1; i < fs.Length / sizeof(double); i++)
            {
                results[i] = br.ReadDouble();
                if (results[i] < tmpMin) tmpMin = results[i];
            }

            br.Close();
            fs.Close();
            min = tmpMin;
            return results;
        }

        static void Task2()
        {
            Console.WriteLine("Задание 2. Модифицировать программу нахождения минимума функции.\n");
            int funcNumber = new int();
            bool stopper = false;
            double answer;
            double a = new double();
            double b = new double();
            double h = new double();
            double[] arrayOfResults;
            string filename = AppDomain.CurrentDomain.BaseDirectory + "Task2File.txt";
            List<FunctionTask2> functions = new List<FunctionTask2> { new FunctionTask2(Func1), new FunctionTask2(Func2), new FunctionTask2(Func3), new FunctionTask2(Func4), new FunctionTask2(Func5) };

            Console.Write("Введите границы промежутка:\na = ");
            while (double.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.Write("Введены некорректные данные, попробуйте еще раз: ");
            }

            Console.Write("\nb = ");
            while (double.TryParse(Console.ReadLine(), out b) == false || a >= b)
            {
                if (a >= b) Console.Write("Верхняя граница b должна быть больше нижней границы a. Укажите другое значение b: ");

                else Console.Write("Введены некорректные данные, попробуйте еще раз: ");
            }

            Console.Write("\nУкажите шаг для значений в интервале: ");
            while (double.TryParse(Console.ReadLine(), out h) == false || h <= 0)
            {
                if (h <= 0) Console.Write("Шаг не может быть меньше нуля или равным нулю. Укажите другой шаг: ");

                else Console.Write("Введены некорректные данные, попробуйте еще раз: ");
            }

            Console.WriteLine("\nДоступны следующие функции:\n" +
                "1)sin2x\n2)(3x - 1)5\n3)cos(7x + 2)\n4)1 / (x^2 - x)\n5)sin2x * sinx");

            do
            {
                Console.Write("\nВведите номер одной из следующих функций для расчета, для выхода введите 0: ");

                if (int.TryParse(Console.ReadLine(), out funcNumber) == false || (funcNumber > 5 || funcNumber < 0))
                {
                    if (funcNumber > 5 || funcNumber < 0) Console.WriteLine("Неизвестный номер функции...\n");
                    else Console.WriteLine("Введены неизвестные символы...\n");
                }

                else if (funcNumber == 0) stopper = true;

                else
                {
                    funcNumber -= 1;
                    SaveFunc(functions[funcNumber], filename, a, b, h);
                    arrayOfResults = Load(filename, out answer);
                    Console.Write("Массив значений: {");
                    for (int i = 0; i < arrayOfResults.Length; i++)
                    {
                        Console.Write(arrayOfResults[i] + ", ");
                    }
                    Console.Write("\b\b}");
                    Console.WriteLine($"\nМинимальное значение: {answer}");
                }
            }
            while (stopper == false);
            Console.WriteLine("Завершение работы...");
        }

        #endregion

        #region Task 3

        class Student
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Grade { get; set; }
            public int ExamPoints { get; set; }
        }

        class CompareByAge : IComparer<Student>
        {
            public int Compare(Student student1, Student student2)
            {
                if (student1.Age > student2.Age) return 1;

                else if (student1.Age < student2.Age) return -1;

                return 0;
            }
        }

        class CompareByGradeAndAge : IComparer<Student>
        {
            public int Compare(Student student1, Student student2)
            {
                if (student1.Grade > student2.Grade) return 1;

                else if (student1.Grade < student2.Grade) return -1;

                else if (student1.Grade == student2.Grade)
                {
                    if (student1.Age > student2.Age) return 1;

                    else if (student1.Age < student2.Age) return -1;

                    return 0;
                }
                return 0;
            }
        }

        class CompareBySurname : IComparer<Student>
        {
            public int Compare(Student student1, Student student2)
            {
                return String.Compare(student1.Surname, student2.Surname);
            }
        }

        static List<Student> LoadStudentsFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            List<Student> students = new List<Student>();
            using (var reader = new FileInfo(fileName).OpenText())
            {
                while (!reader.EndOfStream)
                {
                    string[] studentParts = reader.ReadLine().Split(' ');
                    students.Add(new Student()
                    {
                        Surname = studentParts[0],
                        Name = studentParts[1],
                        Age = int.Parse(studentParts[2]),
                        Grade = int.Parse(studentParts[3]),
                        ExamPoints = int.Parse(studentParts[4])
                    });
                }
            }
            return students;
        }

        #region Count Functions

        static void GradeCounter(int studentInfo, int searchInfo, ref int result)
        {
            if (studentInfo == searchInfo) result++;
        }

        static void AgeCounter(int studentInfo, int searchInfo, ref int result)
        {
            if (studentInfo >= searchInfo) result++;
        }

        static void PointsCounter(int studentInfo, int searchInfo, ref int result)
        {
            if (studentInfo <= searchInfo) result++;
        }

        #endregion

        /*
        Список студентов(Фамилия, имя, возраст, курс, балл за экзамен):
        Григорьев Анатолий 18 1 5
        Шестаков Клим 19 5 3
        Хохлов Мартин 20 4 2
        Шубин Лазарь 17 1 6
        Гущина Арьяна 20 4 8
        Брагина Виоланта 18 4 4
        Афанасьева Екатерина 19 3 6
        Лазарева Снежана 24 5 4
        Лазарева Алла 21 4 10
        Шубин Владлен 17 2 9
        Лыткин Панкратий 18 3 5
        Горбунов Рубен 19 3 4
        Лыткин Герман 17 6 7
        Соколов Орест 23 6 3*/

        static void Task3()
        {
            Console.WriteLine("Задание 3. Переделать программу для получения данных о студентах и сортировке этих данных\n");

            List<Student> students = LoadStudentsFromFile(AppDomain.CurrentDomain.BaseDirectory + "StudentList.txt");

            #region Option a

            int grade5 = 0;
            int grade6 = 0;

            foreach (Student student in students)
            {
                if (student.Grade == 5) grade5++;
                else if (student.Grade == 6) grade6++;
            }

            Console.WriteLine($"Студентов 5-го курса: {grade5}\nСтудентов 6-го курса: {grade6}\n");

            #endregion

            #region Option b

            int[] studentsPerGrade = new int[6];
            foreach (Student student in students)
            {
                if (student.Age >= 18 && student.Age <= 20) studentsPerGrade[student.Grade - 1]++;
            }

            for (int i = 0; i < studentsPerGrade.Length; i++)
            {
                Console.WriteLine($"Студентов {i + 1}-го курса в возрасте от 18 до 20 лет: {studentsPerGrade[i]}");
            }

            #endregion

            #region Option c

            students.Sort(new CompareBySurname());
            students.Sort(new CompareByAge());
            Console.WriteLine("\nСписок студентов по возрасту: ");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Surname} {student.Name} - {student.Age} лет");
            }

            #endregion

            #region Option c

            students.Sort(new CompareBySurname());
            students.Sort(new CompareByGradeAndAge());
            Console.WriteLine("\nСписок студентов по курсу и возрасту: ");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Surname} {student.Name} - Курс: {student.Grade}; Возраст: {student.Age}");
            }

            #endregion

            #region Option e

            Predicate<int> isFound = delegate (int num) { return num > 0; };
            List<CountStudentsFor> countings = new List<CountStudentsFor> { new CountStudentsFor(GradeCounter), new CountStudentsFor(AgeCounter), new CountStudentsFor(PointsCounter) };
            bool stopper = false;
            int op;
            int infoForSearch;
            int result;
            Console.WriteLine("\nВы также можете получить дополнительную информацию о количестве студентов:" +
                "\n1)Учащихся на указанном курсе\n2)Не младше указанного возраста\n3)Написавших экзамен не выше указанного количества баллов");

            do
            {
                Console.Write("\nВведите номер операции подсчета, для выхода введите 0: ");
                result = 0;

                if (int.TryParse(Console.ReadLine(), out op) == false) Console.WriteLine("Введены неизвестные символы...\n");

                else
                {
                    switch (op)
                    {
                        case 1:
                            Console.Write("Укажите искомый курс: ");
                            infoForSearch = int.Parse(Console.ReadLine());
                            foreach (Student student in students)
                            {
                                countings[op - 1](student.Grade, infoForSearch, ref result);
                            }
                            if (isFound(result) == false) Console.WriteLine("Студентов, которых вы ищите, нет в базе данных.");
                            else Console.WriteLine($"На {infoForSearch} курсе учатся {result} студентов");
                            break;

                        case 2:
                            Console.Write("Укажите минимальный возраст искомых студентов: ");
                            infoForSearch = int.Parse(Console.ReadLine());
                            foreach (Student student in students)
                            {
                                countings[op - 1](student.Age, infoForSearch, ref result);
                            }
                            if (isFound(result) == false) Console.WriteLine("Студентов, которых вы ищите, нет в базе данных.");
                            else Console.WriteLine($"Студентов, чей возраст не младше {infoForSearch}: {result}");
                            break;

                        case 3:
                            Console.Write("Укажите максимальное количесвто баллов (от 0 до 10) за экзамен искомых студентов: ");
                            infoForSearch = int.Parse(Console.ReadLine());
                            foreach (Student student in students)
                            {
                                countings[op - 1](student.ExamPoints, infoForSearch, ref result);
                            }
                            if (isFound(result) == false) Console.WriteLine("Студентов, которых вы ищите, нет в базе данных.");
                            else Console.WriteLine($"Студентов, написавших экзамен не выше {infoForSearch} баллов: {result}");
                            break;

                        case 0:
                            Console.WriteLine("Завершение работы...");
                            stopper = true;
                            break;

                        default:
                            Console.WriteLine("Введен неизвестный номер операци...\n");
                            break;
                    }
                }
            }
            while (stopper == false);

            #endregion
        }

        #endregion

        static void Main(string[] args)
        {
            //Программу написал Критский Сергей
            int task = 0;
            bool stopper = false;

            do
            {
                Console.Write("Введите номер задания от 1 до 3 для просмотра, для выхода введите 0: ");

                if (int.TryParse(Console.ReadLine(), out task) == false) Console.WriteLine("Введены неизвестные символы...\n");

                else
                {
                    switch (task)
                    {
                        case 1:
                            Task1();
                            NextTask();
                            break;

                        case 2:
                            Task2();
                            NextTask();
                            break;

                        case 3:
                            Task3();
                            NextTask();
                            break;

                        case 0:
                            Console.WriteLine("Завершение работы программы...");
                            stopper = true;
                            NextTask();
                            break;

                        default:
                            Console.WriteLine("Введен неизвестный номер задания...\n");
                            break;
                    }
                }
            }
            while (stopper == false);
        }
    }
}
