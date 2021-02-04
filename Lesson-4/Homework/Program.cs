using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class SimpleArray
    {
        #region Private fields

        private int[] a;

        #endregion

        #region Constructors

        public SimpleArray(int[] a)
        {
            this.a = a;
        }

        public SimpleArray(int size, int startValue, int step)
        {
            a = new int[size];
            a[0] = startValue;
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i - 1] + step;
            }
        }

        public SimpleArray(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            StreamReader fileData = new StreamReader(filename);
            a = new int[int.Parse(fileData.ReadLine())];
            for (int i = 0; i < a.Length; i++)
            {
                if (int.TryParse(fileData.ReadLine(), out a[i]) == false)
                {
                    throw new FormatException();
                }
            }

        }
        #endregion

        #region Public Properties

        /// <summary>
        /// Индексное свойство
        /// </summary>
        /// <param name="index">Индекс элемента массива</param>
        /// <returns>Значение элемента массива</returns>
        public int this[int index]
        {
            get { return a[index]; }
            set
            {
                a[index] = value;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;


                //return a.Sum();
            }
        }

        public int MaxCount
        {
            get
            {
                int counter = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == a.Max()) counter++;
                }
                return counter;

                //return (from i in a where i == a.Max() select i).Count();
            }
        }

        #endregion

        #region Public Methods

        public int GetValue(int index)
        {
            return a[index];
        }

        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= -1;
            }
        }

        public void Multi(int mult)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= mult;
            }
        }

        public void ArrayToFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            StreamWriter result = new StreamWriter(filename);
            for (int i = 0; i < a.Length; i++)
            {
                result.WriteLine(a[i]);
            }
            result.Close();
        }

        public override string ToString()
        {
            string str = "{";
            for (int i = 0; i < a.Length; i++)
            {
                str += a[i] + ", ";
            }
            return $"{str}\b\b" + "}";
        }

        #endregion
    }

    class TwoDimensionalArray
    {
        #region Private Fields

        private int[,] array;

        #endregion

        #region Constructors

        public TwoDimensionalArray(int[,] array)
        {
            this.array = array;
        }

        public TwoDimensionalArray(int sizeX, int sizeY, int startValue, int endValue)
        {
            array = new int[sizeY, sizeX];
            Random number = new Random();
            for(int i = 0; i < sizeY; i++)
            {
                for(int j = 0; j < sizeX; j++)
                {
                    array[i, j] = number.Next(startValue, endValue + 1);
                }
            }
        }

        public TwoDimensionalArray(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            StreamReader fileData = new StreamReader(filename);
            array = new int[int.Parse(fileData.ReadLine()), int.Parse(fileData.ReadLine())];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (int.TryParse(fileData.ReadLine(), out array[i, j]) == false)
                    {
                        throw new FormatException();
                    }
                }
            }
        }

        #endregion

        #region Public Properties

        public int[,] Array
        {
            get
            {
                return array;
            }
        }

        public int Min
        {
            get
            {
                int min = array[0,0];
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for(int j = 0; j < array.GetLength(1); j++)
                    {
                        if (min > array[i, j]) min = array[i, j];
                    }
                }
                return min;
            }
        }

        public int Max
        {
            get
            {
                int max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (max < array[i, j]) max = array[i, j];
                    }
                }
                return max;
            }
        }

        #endregion

        #region Public Methods

        public int Sum()
        {
            int sum = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }

        public int SumMoreThan(int number)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] > number) sum += array[i, j];
                }
            }
            return sum;
        }

        public void IndexMax(out int x, out int y)
        {
            x = new int();
            y = new int();
            int indexValue = Max;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == indexValue)
                    {
                        x = j;
                        y = i;
                        return;
                    }
                }
            }
        }

        public void ArrayToFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            StreamWriter result = new StreamWriter(filename);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) {
                    result.Write(String.Format("{0,5}", array[i, j]));
                }
                result.WriteLine();
            }
            result.Close();
        }

        public void PrintArray()
        {
            string str = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,5}", array[i, j]));
                }
                Console.WriteLine();
            }
        }
        #endregion
    }

    struct Account
    {
        #region Private Fields

        private string login;
        private string password;

        #endregion

        #region Public Methods

        public void EnterAccountData(string[] loginAndPassword)
        {
            login = loginAndPassword[0];
            password = loginAndPassword[1];
        }

        public bool TryAccount()
        {
            if (login == "root" && password == "GeekBrains") return true;
            return false;
        }

        #endregion
    }

    class Program
    {
        static void NextTask()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
        }

        static void Task1()
        {
            Console.WriteLine("Задание 1. Программа подсчитывает в целочисленном масиве количество пар(два подряд идущих элемента), в которых одно из чисел делится на 3.");

            int[] array = new int[20];
            int answer = 0;
            string textArray = "{";

            Console.WriteLine("\nЗаполните масисв целыми числами от -10 000 до 10 000 включительно");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент {i + 1} = ");
                if (int.TryParse(Console.ReadLine(), out array[i]) == false || array[i] > 10000 || array[i] < -10000)
                {
                    Console.WriteLine("Введены некорректные данные.");
                    i--;
                }
                else textArray += array[i] + ", ";
            }

            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i - 1] % 3 == 0 && array[i - 1] != 0) || (array[i] % 3 == 0 && array[i] != 0))
                {
                    answer++;
                }
            }

            Console.WriteLine($"\nВ введенном массиве {textArray}\b\b" + "}" + $" количество пар, где хотя бы одно число делится на 3 равно {answer}");
        }

        static void Task2()
        {
            #region Simple Array

            Console.WriteLine("Задание 2. Добавить к классу одномерных массивов конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. Также добавить несколько новых методов");

            Console.Write($"\nУкажите размерность массива(она должна быть больше 0): ");
            int size;
            while (int.TryParse(Console.ReadLine(), out size) == false || size <= 0)
            {
                Console.Write("Указана некорректная размерность массива, введите другие данные: ");
            }

            Console.Write($"\nУкажите начальное значение: ");
            int startValue;
            while (int.TryParse(Console.ReadLine(), out startValue) == false)
            {
                Console.Write("Указано некорректное стартовое значение, введите другие данные: ");
            }

            Console.Write($"\nУкажите шаг для значений массива: ");
            int step;
            while (int.TryParse(Console.ReadLine(), out step) == false)
            {
                Console.Write("Указан некорректный шаг, введите другие данные: ");
            }

            SimpleArray arrayTask2 = new SimpleArray(size, startValue, step);
            Console.WriteLine($"\nПолучившийся массив: {arrayTask2}");
            Console.WriteLine($"Сумма элементов массива: {arrayTask2.Sum}");

            arrayTask2.Inverse();
            Console.WriteLine($"Массив с измененными знаками: {arrayTask2}");
            arrayTask2.Inverse();

            Console.WriteLine($"Количество максимальных элементов в массиве: {arrayTask2.MaxCount}");

            Console.Write($"\nУкажите множитель для значений массива(метод Multi): ");
            int mult;
            while (int.TryParse(Console.ReadLine(), out mult) == false)
            {
                Console.Write("Указан некорректный множитель, введите другие данные: ");
            }
            arrayTask2.Multi(mult);
            Console.WriteLine($"Массив, элементы которого умножены на {mult}: {arrayTask2}");

            NextTask();
            #endregion

            #region Simple Array From/To File

            try
            {
                SimpleArray arrayTask2File = new SimpleArray(AppDomain.CurrentDomain.BaseDirectory + "SimpleArrayFile.txt");
                Console.WriteLine($"Загруженный из файла массив: {arrayTask2File}");

                arrayTask2File.Multi(mult);
                arrayTask2File.ArrayToFile(AppDomain.CurrentDomain.BaseDirectory + "SimpleArrayResult.txt");
                Console.WriteLine($"После умножения каждого элемента на {mult}, получился массив: {arrayTask2File}. Он загружен в файл SimpleArrayResult.txt в папке .../bin/Debug");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Имя файла для записи или считывания массива указано неверно");
            }
            catch (FormatException)
            {
                Console.WriteLine("Данные в файле не подходят для создания массива");
            }

            #endregion
        }

        static void Task3()
        {
            Console.WriteLine("Задание 3. Программа проверяет корректность логинов и паролей, записанных в файле.\n");

            try
            {
                int counter = 1;
                string[] loginAndPassword = new string[2];
                Account user = new Account();

                if(!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "LoginsAndPasswords.txt"))
                {
                    throw new FileNotFoundException();
                }

                StreamReader accountData = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "LoginsAndPasswords.txt");
                do
                {
                    loginAndPassword[0] = accountData.ReadLine();
                    loginAndPassword[1] = accountData.ReadLine();

                    Console.WriteLine($"Пользователь {counter}:");
                    Console.WriteLine($"Логин: {loginAndPassword[0]}");
                    Console.WriteLine($"Пароль: {loginAndPassword[1]}\n");

                    user.EnterAccountData(loginAndPassword);
                    if (user.TryAccount() == false)
                    {
                        Console.WriteLine("Пользователь не прошел проверку");
                        NextTask();
                    }
                    else
                    {
                        Console.WriteLine("Данные, введенные пользователем, корректны!");
                        NextTask();
                    }
                    counter++;
                }
                while (!accountData.EndOfStream);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Отсутствует файл с логинами а паролями");
            }
            Console.WriteLine("Пользователей для проверки не осталось.");
        }

        static void Task4()
        {
            #region Two-Dimensional Array

            Console.WriteLine("Задание 4. Реализовать класс двумерных массивов с определенными свойствами и параметрами.");

            Console.Write($"\nУкажите размерность двумерного массива(она должна быть больше 0):\nx = ");
            int sizeX;
            while (int.TryParse(Console.ReadLine(), out sizeX) == false || sizeX <= 0)
            {
                Console.Write("Указана некорректная размерность массива, введите другие данные: ");
            }

            Console.Write("y = ");
            int sizeY;
            while (int.TryParse(Console.ReadLine(), out sizeY) == false || sizeY <= 0)
            {
                Console.Write("Указана некорректная размерность массива, введите другие данные: ");
            }

            Console.Write($"\nУкажите начальное значение для заполнения массива случайными числами(Желательно использовать числа <10 000): ");
            int startValue;
            while (int.TryParse(Console.ReadLine(), out startValue) == false)
            {
                Console.Write("Указано некорректное стартовое значение, введите другие данные: ");
            }

            Console.Write($"\nУкажите конечное значение для заполнения массива случайными числами(Желательно использовать числа <10 000): ");
            int endValue;
            while (int.TryParse(Console.ReadLine(), out endValue) == false)
            {
                Console.Write("Указано некорректное стартовое значение, введите другие данные: ");
            }

            TwoDimensionalArray arrayTask4 = new TwoDimensionalArray(sizeX, sizeY, startValue, endValue);

            Console.WriteLine($"\nСлучайно сгенерированный массив:");
            arrayTask4.PrintArray();

            Console.WriteLine($"\nСумма всех элементов массива равна {arrayTask4.Sum()}");

            Console.Write($"\nУкажите число, для подсчета суммы чисел, выше заданного вами: ");
            int number = new int();
            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.Write("Указано некорректное стартовое значение, введите другие данные: ");
            }
            Console.WriteLine($"Сумма чисел, больших {number} равна {arrayTask4.SumMoreThan(number)}");

            Console.WriteLine($"\nМинимальный элемент массива {arrayTask4.Min}");

            Console.WriteLine($"\nМаксимальный элемент массива {arrayTask4.Max}");

            int x;
            int y;
            arrayTask4.IndexMax(out x, out y);
            Console.WriteLine($"\nИндекс максимального значения в массиве [{x}, {y}]");

            NextTask();
            #endregion

            #region Two-Dimensional Array From/To File

            try
            {
                TwoDimensionalArray arrayTask4File = new TwoDimensionalArray(AppDomain.CurrentDomain.BaseDirectory + "TwoDimensionalArrayFile.txt");
                Console.WriteLine($"Загруженный из файла массив:");
                arrayTask4File.PrintArray();

                Console.Write("Введите число, которе требуется прибавить к каждому элементу массива: ");
                int term;
                while (int.TryParse(Console.ReadLine(), out term) == false)
                {
                    Console.Write("Указано не целое число, попробуйте снова: ");
                }
                for(int i = 0; i < arrayTask4File.Array.GetLength(0); i++)
                {
                    for(int j = 0; j < arrayTask4File.Array.GetLength(1); j++)
                    {
                        arrayTask4File.Array[i, j] += term;
                    }
                }

                arrayTask4File.ArrayToFile(AppDomain.CurrentDomain.BaseDirectory + "TwoDimensionalArrayFileResult.txt");
                Console.WriteLine($"После прибавления к каждому элементу числа {term}, получился массив:");
                arrayTask4File.PrintArray(); 
                Console.WriteLine("Он загружен в файл TwoDimensionalArrayFileResult.txt в папке .../bin/Debug");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Имя файла для записи или считывания массива указано неверно");
            }
            catch (FormatException)
            {
                Console.WriteLine("Данные в файле не подходят для создания массива");
            }

            #endregion
        }

        static void Main(string[] args)
        {
            //Программу написал Критский Сергей
            int task = 0;
            bool stopper = false;

            do
            {
                Console.Write("Введите номер задания от 1 до 4 для просмотра, для выхода введите 0: ");

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