using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework
{
    static class Message
    {
        public static string[] separators = { " ", ",", ".", "-", "!", "?", ":", ";", "\r\n" };

        public static string PrintWordsByLength(string message, int symbols)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string answer = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= symbols)
                {
                    answer += words[i] + ", ";
                }
            }
            answer += "\b\b ";
            return answer;
        }

        public static StringBuilder DeleteSomeWords(string message, char lastSymbol)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder msg = new StringBuilder(message);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length - 1] == lastSymbol)
                {
                    msg.Replace(words[i], "");
                }
            }
            return msg;
        }

        public static string MaxLength(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int maxLength = 0;
            string answer = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength)
                {
                    answer = words[i];
                    maxLength = words[i].Length;
                }
            }
            return answer;
        }

        public static StringBuilder PrintLongestWords(string message)
        {
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder answer = new StringBuilder("");
            int maxLength = MaxLength(message).Length;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == maxLength)
                {
                    answer.Append(words[i]);
                    answer.Append(", ");
                }
            }
            answer.Append("\b\b ");
            return answer;
        }
    }

    class Program
    {
        static void NextTask()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
        }

        static void FindStudents(string[] students, double[] averalMarks, double valueForSearch)
        {
            Console.WriteLine($"\nСписок учеников с баллом {valueForSearch:f}.");
            for (int i = 0; i < students.Length; i++)
            {
                if (averalMarks[i] == valueForSearch) Console.WriteLine(students[i].Substring(0, students[i].Length - 6));
            }
        }

        static void Task1()
        {
            #region No Regex

            Console.WriteLine("Задание 1, пункт а. Программа проверяет кореектность введенного логина (без использования регулярных выражений).\n");
            bool isAuthorized;
            StringBuilder loginOptA;
            Console.Write("Введите ваш логин(его длина должна быть от 2 до 10 символов, он должен состоять ТОЛЬКО из цифр и латинских букв, при этом первый символ не может быть цифрой). ");

            do
            {
                isAuthorized = true;
                Console.Write("\nLogin: ");
                loginOptA = new StringBuilder(Console.ReadLine());

                if (char.IsDigit(loginOptA[0]) || (loginOptA[0] < 'a' || loginOptA[0] > 'z') && (loginOptA[0] < 'A' || loginOptA[0] > 'Z'))
                {
                    Console.WriteLine("Введенный логин некорректен: первый символ логина должен быть буквой латинского алфавита.");
                    isAuthorized = false;
                }

                else if (loginOptA.Length < 2 || loginOptA.Length > 10)
                {
                    Console.WriteLine("Введенный логин некорректен: длина логина не соответствует требованиям.");
                    isAuthorized = false;
                }

                else
                {
                    for (int i = 1; i < loginOptA.Length; i++)
                    {
                        if (!char.IsDigit(loginOptA[i]) && (loginOptA[i] < 'a' || loginOptA[i] > 'z') && (loginOptA[i] < 'A' || loginOptA[i] > 'Z'))
                        {
                            Console.WriteLine("Введенный логин некорректен: в нем присутствуют неизвестные символы.");
                            isAuthorized = false;
                            break;
                        }
                    }
                }
            } while (isAuthorized == false);

            Console.WriteLine("Пользователь авторизован.");
            NextTask();

            #endregion

            #region Regex

            Console.WriteLine("Задание 1, пункт б. Программа проверяет кореектность введенного логина (c использованием регулярных выражений).\n");

            Regex loginRules = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,9}$");
            bool isAuthorizedOptB;
            string loginOptB;
            Console.Write("Введите ваш логин(его длина должна быть от 2 до 10 символов, он должен состоять ТОЛЬКО из цифр и латинских букв, при этом первый символ не может быть цифрой). ");

            do
            {
                isAuthorizedOptB = true;
                Console.Write("\nLogin: ");
                loginOptB = Console.ReadLine();

                if (loginRules.IsMatch(loginOptB) == false)
                {
                    Console.Write("Введенный логин некорректен: ");

                    if (new Regex(@"^[a-zA-Z]").IsMatch(loginOptB) == false) Console.WriteLine("первый символ должен быть буквой латинского алфавита");
                    else if (new Regex(@"[^a-zA-Z0-9]").IsMatch(loginOptB) == true) Console.WriteLine("в нем присутствуют неизвестные символы");
                    else Console.WriteLine("длина логина не соответствует требованиям");

                    isAuthorizedOptB = false;
                }
            }
            while (isAuthorizedOptB == false);

            Console.WriteLine("Пользователь авторизован.");
            #endregion
        }

        static void Task2()
        {
            Console.WriteLine("Задание 2. Разработать класс Message с некоторыми статическими методами. Сам текст находится в файле Message.txt\n");


            string message = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Message.txt");

            Console.Write("Укажите, какой максимальной длины слова надо вывести: ");
            int symbolsAmmount;
            while (int.TryParse(Console.ReadLine(), out symbolsAmmount) == false)
            {
                Console.WriteLine("\nВведите число!: ");
            }
            Console.WriteLine($"\nСлова, которые содержат не более {symbolsAmmount} букв:\n{Message.PrintWordsByLength(message, symbolsAmmount)}");
            NextTask();

            Console.Write("Укажите символ, на который должны заканчиваться слова для удаления: ");
            char deleteSymbol;
            while (char.TryParse(Console.ReadLine(), out deleteSymbol) == false)
            {
                Console.Write("\nУкажите один символ!: ");
            }
            Console.WriteLine($"\nВведенный текст без слов, заканичвающихся на символ {deleteSymbol}:\n{Message.DeleteSomeWords(message, deleteSymbol)}");
            NextTask();

            Console.WriteLine($"Первое самое длинное слово сообщения: {Message.MaxLength(message)}");
            NextTask();

            Console.WriteLine($"Строка из самых длинных слов сообщения: {Message.PrintLongestWords(message)}");
        }

        static void Task3()
        {
            #region Option a

            Console.WriteLine("Задание 3, пункт а. Программа проверяет, является ли одна из двух введенных строчек результатом переставления символов в другой(Сделано с учетом регистра).\n");

            char[] string1;
            char[] string2;
            bool isACopy = true;

            Console.Write("Введите две строчки.\nПервая строка:");
            string1 = Console.ReadLine().ToCharArray();
            Console.Write("Вторая строка:");
            string2 = Console.ReadLine().ToCharArray();

            if (string1.Length != string2.Length)
            {
                Console.WriteLine("Набор символов в строках НЕ индентичен, одна строка не является следствием перестановки символов другой");
                isACopy = false;
            }

            else
            {
                Array.Sort(string1);
                Array.Sort(string2);
                for (int i = 0; i < string1.Length; i++)
                {
                    if (string1[i] != string2[i])
                    {
                        Console.WriteLine("Набор символов в строках НЕ индентичен, одна строка не является следствием перестановки символов другой");
                        isACopy = false;
                        break;
                    }
                }
            }
            if (isACopy == true) Console.WriteLine("Набор символов в строках индентичен, одна строка является следствием перестановки символов в другой");
            NextTask();

            #endregion

            #region Option b

            Console.WriteLine("Задание 3, пункт б. Разработать свой алгоритм проверки, является ли одна из двух введенных строчек результатом переставления символов в другой(Сделано с учетом регистра).\n");

            StringBuilder string3;
            StringBuilder string4;
            isACopy = true;

            Console.Write("Введите две строчки.\nПервая строка:");
            string3 = new StringBuilder(Console.ReadLine());
            Console.Write("Вторая строка:");
            string4 = new StringBuilder(Console.ReadLine());

            if (string1.Length != string2.Length)
            {
                Console.WriteLine("Набор символов в строках НЕ индентичен, одна строка не является следствием перестановки символов другой");
                isACopy = false;
            }

            else
            {
                for (int i = 0; i < string3.Length; i++)
                {
                    for (int j = 0; j < string4.Length; j++)
                    {
                        if (string3[i] == string4[j])
                        {
                            string4.Remove(j, 1);
                            break;
                        }

                        else if (j == string4.Length - 1)
                        {
                            Console.WriteLine("Набор символов в строках НЕ индентичен, одна строка не является следствием перестановки символов другой");
                            isACopy = false;
                        }
                    }
                    if (isACopy == false) break;
                }

                if (isACopy == true) Console.WriteLine("Набор символов в строках индентичен, одна строка является следствием перестановки символов другой");
            }

            #endregion
        }

        static void Task4()
        {
            Console.WriteLine("Задание 4. Программа считывает информацию об учениках и их оценках и выводит тройку худших учеников.\n");

            int N;
            double sum;
            double min1, min2, min3;
            double[] averalMarks;
            string[] students;
            Regex studentInfoRules = new Regex(@"^[a-zA-Zа-яА-Я]{1,20}\s[a-zA-Zа-яА-Я]{1,15}\s([1-5]\s){2}[1-5]$");

            Console.Write("Укажите количество учеников(от 10 до 100): ");
            while (int.TryParse(Console.ReadLine(), out N) == false || (N < 10 || N > 100))
            {
                Console.Write("Введены некорректные данные. Укажите другое значение: ");
            }

            students = new string[N];
            averalMarks = new double[N];
            Console.WriteLine("\nВведите информацию об учениках: фаимилию, имя и три итоговых оценки (Через пробелы).");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ученик №{i + 1}: ");
                students[i] = Console.ReadLine();
                while (studentInfoRules.IsMatch(students[i]) == false)
                {
                    Console.Write("Информация указана неверно, попробуйте снова: ");
                    students[i] = Console.ReadLine();
                }

                sum = int.Parse(Convert.ToString(students[i][students[i].Length - 1])) + int.Parse(Convert.ToString(students[i][students[i].Length - 3])) + int.Parse(Convert.ToString(students[i][students[i].Length - 5]));
                averalMarks[i] = sum / 3;
            }

            double[] tmp = new double[N];
            Array.Copy(averalMarks, tmp, N);
            Array.Sort(tmp);

            min1 = tmp[0];
            FindStudents(students, averalMarks, min1);

            if (Array.LastIndexOf(tmp, min1) != tmp.Length - 1)
            {

                min2 = tmp[Array.LastIndexOf(tmp, min1) + 1];
                FindStudents(students, averalMarks, min2);

                if (Array.LastIndexOf(tmp, min2) != tmp.Length - 1)
                {
                    min3 = tmp[Array.LastIndexOf(tmp, min2) + 1];
                    FindStudents(students, averalMarks, min3);
                }
            }
        }

        static void Task5()
        {
            Console.WriteLine("Задание 5. Игра 'Верю. Не верю'");

            int points = 0;
            string questionNumber;
            string userAnswer;
            string rightAnswer = string.Empty;
            string[] questions = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "quiz.txt");
            string[] usedQuestions = new string[5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"\nВопрос №{i + 1}: ");
                userAnswer = "";

                do
                {
                    questionNumber = Convert.ToString(rnd.Next(1, 11));
                    if (usedQuestions.Contains(questionNumber) == false)
                    {
                        for (int j = 0; j < questions.Length; j++)
                        {
                            if (questions[j].StartsWith(questionNumber))
                            {
                                Console.WriteLine(questions[j].Substring(2, questions[j].Length - 2));
                                rightAnswer = questions[j + 1];
                                usedQuestions[i] = questionNumber;
                                break;
                            }
                        }
                        Console.Write("Веришь?: ");
                        userAnswer = Console.ReadLine();
                        if (userAnswer.ToLower() == rightAnswer.ToLower()) points++;
                    }
                }
                while (userAnswer == "");
            }

            Console.WriteLine($"\nИгра окончена! Набрано очков: {points}");
        }

        static void Main(string[] args)
        {
            //Программу написал Критский Сергей
            int task = 0;
            bool stopper = false;

            do
            {
                Console.Write("Введите номер задания от 1 до 5 для просмотра, для выхода введите 0: ");

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

                        case 4:
                            Task4();
                            NextTask();
                            break;

                        case 5:
                            Task5();
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