using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Task6
    {
        public static void NextTask()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PrintCenter(string text)
        {
            var width = Console.WindowWidth;
            var padding = width / 2 + text.Length / 2;
            Console.WriteLine("{0, " + padding + "}", text + "\n");
        }
    }

    class Program
    {
        static double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            //Написал Критский Сергей
            #region Task 1
            Console.WriteLine("Задание 1. Программа считывает информацию о пользователе и выводит всю информацию в одну строчку.");
            
            Console.Write("Ваше имя: ");
            var name = Console.ReadLine();
            Console.Write("Ваша фамилия: ");
            var surname = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            var age = Console.ReadLine();
            Console.Write("Ваш рост в сантиметрах: ");
            var height = Console.ReadLine();
            Console.Write("Ваш вес: ");
            var weight = Console.ReadLine();

            #region Option a
            string answer = "Меня зовут " + name + " " + surname + ". Мне " + age + " лет. Мои рост и вес: " + height + "см., " + weight + "кг.";
            Console.WriteLine("\nСклеивание строк: " + answer);
            #endregion

            #region Option b
            Console.WriteLine("\nФорматированный вывод: Меня зовут {0} {1}. Мне {2} лет. Мои рост и вес: {3}см., {4}кг.", name, surname, age, height, weight);
            #endregion

            #region Option c
            Console.WriteLine($"\nВывод со знаком $: Меня зовут {name} {surname}. Мне {age} лет. Мои рост и вес: {height}см., {weight}кг.");
            #endregion

            Task6.NextTask();
            #endregion

            #region Task 2
            Console.WriteLine("Задание 2. Программа расчитывает и выводи индекс массы тела.");

            Console.Write("Введите ваш рост (в сантиметрах): ");
            var h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш вес: ");
            var m = Convert.ToDouble(Console.ReadLine());
            var l = m / Math.Pow((h/100), 2);
            Console.WriteLine("Индекс массы тела равен " + l);

            Task6.NextTask();
            #endregion

            #region Task 3
            Console.WriteLine("Задание 3. Программа расчитывает и выводит расстояние между двумя точками.");

            Console.WriteLine("Укажите координаты первой точки:");
            Console.Write("x1 = ");
            var x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            var y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите координаты второй точки:");
            Console.Write("x2 = ");
            var x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            var y2 = Convert.ToInt32(Console.ReadLine());

            #region Option a
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками с координатами ({x1}, {y1}) и ({x2}, {y2}) равно {r:f2}");
            #endregion

            #region Option b
            r = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine($"\nРасстояние между точками с координатами ({x1}, {y1}) и ({x2}, {y2}) равно {r:f2} - расчет отдельным методом");
            #endregion

            Task6.NextTask();
            #endregion

            #region Task 4
            Console.WriteLine("Задание 4. Программа обменивает значения двух переменных.");

            Console.WriteLine("Введите значения двух переменных:");
            Console.Write("A = ");
            var A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            var B = Convert.ToInt32(Console.ReadLine());

            #region Option a
            var tmp = A;
            A = B;
            B = tmp;
            Console.WriteLine($"\nРезультат обмена значениями:\nA = {A}\nB = {B}");
            #endregion

            #region Option b
            A = A + B;
            B = A - B;
            A = A - B;
            Console.WriteLine($"\nПоменяли значения обратно, но уже без третьей переменной:\nA = {A}\nB = {B}");
            #endregion

            Task6.NextTask();
            #endregion

            #region Task 5
            Console.WriteLine("Задание 5. Программа считывает информацию о пользователе и выводит полученную информацию.");

            Console.Write("Ваше имя: ");
            var nameTask5 = Console.ReadLine();
            Console.Write("Ваша фамилия: ");
            var surnameTask5 = Console.ReadLine();
            Console.Write("Ваш город проживания: ");
            var cityTask5 = Console.ReadLine();

            #region Option a
            Console.WriteLine($"\nМеня зовут {nameTask5} {surnameTask5}. Я проживаю в городе {cityTask5}.\n");
            #endregion

            #region Option b
            string text = "Меня зовут" + nameTask5 + " " + surnameTask5 + ". Я проживаю в городе " + cityTask5 + ".";
            var width = Console.WindowWidth;
            var padding = width / 2 + text.Length / 2;
            Console.WriteLine("{0, " + padding + "}", text + "\n");
            #endregion

            #region Option c
            Console.WriteLine("Вывод отдельным методом:");
            Task6.PrintCenter(text);
            #endregion

            Task6.NextTask();
            #endregion
        }
    }
}
