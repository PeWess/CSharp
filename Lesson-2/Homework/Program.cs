using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void NextTask()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
        }

        enum UserStatus
        {
            NotAuthorized,
            Authorized,
            Banned
        }

        static void Task1()
        {
            Console.WriteLine("Задание 1. Программа возвращает минимальное из трех чисел");

            Console.WriteLine("\nВведите числа A, B и С:");
            Console.Write("A = ");
            var A = double.Parse(Console.ReadLine());
            var min = A;
            
            Console.Write("B = ");
            var B = double.Parse(Console.ReadLine());
            if (B < min) min = B;
            
            Console.Write("C = ");
            var C = double.Parse(Console.ReadLine());
            if (C < min) min = C;

            Console.WriteLine($"Минимальное число равно {min}.");
        }

        static void Task2()
        {
            Console.WriteLine("Задание 2. Программа подсчитывает количесвто цифр числа.");

            Console.Write("Введите целое число: ");
            var number = int.Parse(Console.ReadLine());
            int counter = 0;
            do
            {
                number /= 10;
                counter++;
            }
            while (number != 0);
            Console.WriteLine($"Количество цифр введеного числа равно {counter}");
        }

        static void Task3()
        {
            Console.WriteLine("Задание 3. Вводятся числа, пока не будет введен 0. Программа подсчитывает сумму всех нечетных положительных чисел.\n");

            int sum = 0;
            int number;
            Console.WriteLine("Вводите любые целые числа. Введите 0 для выхода из цикла.");
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number % 2 != 0) sum += number;
            } while (number != 0);
            Console.WriteLine($"Сумма введенных нечетных положительных чисел равна {sum}");
        }

        static void Task4()
        {
            Console.WriteLine("Задание 4. Программа проверяет правильность введенных логина и пароля пользователя.\n");

            UserStatus user = UserStatus.NotAuthorized;
            string login = "root";
            string password = "GeekBrains";
            bool proceed = false;
            int attempts = 3;
            while (proceed == false)
            {
                switch (user)
                {
                    case UserStatus.NotAuthorized:
                        do
                        {
                            Console.WriteLine($"Осталось попыток: {attempts}\nВведите свои логин и пароль");
                            Console.Write("login: ");
                            var userLogin = Console.ReadLine();
                            Console.Write("Password: ");
                            var userPassword = Console.ReadLine();
                            if (userLogin != login && userPassword != password)
                            {
                                Console.WriteLine("\nВведены неправильные логин или пароль.");
                                attempts--;
                            }
                            else
                            {
                                user = UserStatus.Authorized;
                                break;
                            }
                        } while (attempts != 0);
                        if (attempts == 0) user = UserStatus.Banned;
                        break;

                    case UserStatus.Authorized:
                        Console.WriteLine($"\nДобро пожаловать в систему, пользователь {login}.");
                        proceed = true;
                        break;

                    case UserStatus.Banned:
                        Console.WriteLine("Количество попыток закончилось, вы временно заблокированы.");
                        proceed = true;
                        break;
                }
            }
        }

        static void Task5()
        {
            Console.WriteLine("Задание 5. Программа вычисляет индекс массы тела пользователя и сообщает ему, нужно ли набирать массу или худеть.\n");

            Console.Write("Укажите ваш рост (В сантиметрах): ");
            var h = float.Parse(Console.ReadLine());
            Console.Write("Укажите ваш вес (В килограммах): ");
            var m = float.Parse(Console.ReadLine());
            var I = m / Math.Pow((h / 100), 2);
            if (I < 18.5)
            {
                var wantedWeight = 18.5 * Math.Pow((h / 100), 2);
                Console.WriteLine($"\nУ вас дефицит массы тела. Вам необходимо набрать как минимум {(wantedWeight - m):f2}кг.");
            }
       
            else if(I >= 18.5 && I <= 25)
            {
                Console.WriteLine($"\nПоздравляю, вы в норме!");
            }

            else if (I > 25)
            {
                var wantedWeight = 25 * Math.Pow((h / 100), 2);
                Console.WriteLine($"\nУ вас избыточная масса тела. Вам необходимо сбросить как минимум {(m - wantedWeight):f2}кг.");
            }
        } 

        static void Task6()
        {
            Console.WriteLine("Программа считает количество 'Хороших' чисел в диапазоне от 1 до млрд.");

            int amount = 0;
            int sum;
            int number;
            var start = DateTime.Now;
            for(int i = 1; i <= 1000000000; i++)
            {
                sum = 0;
                number = i;
                do
                {
                    sum += number % 10;
                    number /= 10;
                }
                while (number != 0);
                if(i % sum == 0)
                {
                    amount++;
                }
            }
            var finish = DateTime.Now;
            Console.WriteLine($"Количество чисел от 1 до млрд., делящихся на сумму своих цифр равно {amount}.\nПотрачено времени на выполнение подсчета: {finish - start}");
        }

        static void Task7(int a, int b, ref int sum)
        {
            if(a <= b)
            {
                Task7(a, b - 1, ref sum);
                sum += b;
                Console.WriteLine(b);
            }
        }

        static void Main(string[] args)
        {
            //Программу написал Критский Сергей
            int task;
            bool stopper = false;

            while (stopper == false)
            {
                Console.Write("Введите номер задания от 1 до 7 для просмотра, для выхода введите 0 : ");
                task = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (task)
                {
                    case 0:
                        Console.WriteLine("Выход из программы...");
                        stopper = true;
                        break;

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

                    case 6:
                        Task6();
                        NextTask();
                        break;

                    case 7:
                        Console.WriteLine("Задание 7. Программа выводит все числа от a до b, а также подсчитывает их сумму.\n");
                        int sum = 0;
                        Console.Write("Число а = ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Число b (оно должно быть строго больше числа a) = ");
                        int b = int.Parse(Console.ReadLine());
                        while (a >= b)
                        {
                            Console.Write("\nЧисло b меньше числа а, введите другое значение: b = ");
                            b = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"Числа от {a} до {b}:");
                        Task7(a, b, ref sum);
                        Console.WriteLine($"Сумма этих чисел равна {sum}");
                        NextTask();
                        break;

                    default:
                        Console.WriteLine("Неизвестный номер задания...\n");
                        break;
                }
            }
            NextTask();
        }
    }
}
