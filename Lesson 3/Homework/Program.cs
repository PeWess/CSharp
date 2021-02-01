using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    struct ComplexOptionA
    {
        #region Fields
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        #endregion

        #region Public Methods

        public static ComplexOptionA operator +(ComplexOptionA x, ComplexOptionA y)
        {
            return new ComplexOptionA { im = x.im + y.im, re = x.re + y.re };
        }

        public static ComplexOptionA operator -(ComplexOptionA x, ComplexOptionA y)
        {
            return new ComplexOptionA { im = x.im - y.im, re = x.re - y.re };
        }

        public override string ToString()
        {
            if (im < 0) return $"{re} - {Math.Abs(im)}i";
            else return $"{re} + {im}i";
        }

        #endregion
    }

    class ComplexOptionB
    {

        #region Private Fields

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        double re;

        #endregion

        #region Public Properties

        public double Im
        {
            get
            {
                return im;
            }

            set
            {
                im = value;
            }
        }

        public double Re
        {
            get
            {
                return re;
            }

            set
            {
                re = value;
            }
        }

        #endregion

        #region Constructors

        public ComplexOptionB()
        {
            im = 0;
            re = 0;
        }

        public ComplexOptionB(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        #endregion

        #region Public Methods

        public static ComplexOptionB operator +(ComplexOptionB x, ComplexOptionB y)
        {
            return new ComplexOptionB { im = x.im + y.im, re = x.re + y.re };
        }

        public static ComplexOptionB operator -(ComplexOptionB x, ComplexOptionB y)
        {
            return new ComplexOptionB { im = x.im - y.im, re = x.re - y.re };
        }

        public static ComplexOptionB operator *(ComplexOptionB x, ComplexOptionB y)
        {
            return new ComplexOptionB { im = x.im * y.im, re = x.re * y.re };
        }

        public override string ToString()
        {
            if (im < 0) return $"{re} - {Math.Abs(im)}i";
            else return $"{re} + {im}i";
        }

        #endregion

    }

    class Fraction
    {
        #region Private Fields

        int _numerator;
        int _denominator;

        #endregion

        #region Public Properties

        public int Numerator
        {
            get
            {
                return _numerator;
            }

            set
            {
               _numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return _denominator;
            }

            set
            {
                _denominator = value;
                if (value == 0) throw new DivideByZeroException();
            }
        }

        #endregion

        #region Constructors
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        #endregion

        #region Public Methods

        public static int CommonDivisor(int num1, int num2) //Функция, отвечающая за нахождение наибольшего общего делителя
        {
            int a = Math.Abs(num1);
            int b = Math.Abs(num2);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int CommonMultiple(int num1, int num2) //Функция, отвечающая за нахождение наименьшего общего кратного
        {
            return num1 * num2 / CommonDivisor(num1, num2);
        }

        public static void CommonDenominator(Fraction x, Fraction y) //Функция, отвечающая за приведение дробей к общему знаментаелю
        {
            int multiple = CommonMultiple(x._denominator, y._denominator);
            x._numerator *= (multiple / x._denominator);
            y._numerator *= (multiple / y._denominator);
            x._denominator = multiple;
            y._denominator = multiple;
        }

        public static void Simplification(Fraction x)//Функция, отвечающая за упрощение дробей
        {
            int divisor = CommonDivisor(x._numerator, x._denominator);
            x._numerator /= divisor;
            x._denominator /= divisor;
        }

        public static Fraction operator +(Fraction x, Fraction y)
        {
            if(x._denominator != y._denominator) CommonDenominator(x, y);
            Fraction answer = new Fraction { _numerator = x._numerator + y._numerator, _denominator = x._denominator };
            Simplification(answer);
            return answer;
        }

        public static Fraction operator -(Fraction x, Fraction y)
        {
            if (x._denominator != y._denominator) CommonDenominator(x, y);
            Fraction answer = new Fraction { _numerator = x._numerator - y._numerator, _denominator = x._denominator };
            Simplification(answer);
            return answer;
        }

        public static Fraction operator *(Fraction x, Fraction y)
        {

            Fraction.Simplification(x);
            Fraction.Simplification(y);
            return new Fraction { _numerator = x._numerator * y._numerator, _denominator = x._denominator * y._denominator};
        }

        public static Fraction operator /(Fraction x, Fraction y)
        {
            Fraction.Simplification(x);
            Fraction.Simplification(y);
            if (y._numerator == 0) throw new DivideByZeroException();
            return new Fraction { _numerator = x._numerator * y._denominator, _denominator = y._numerator * x._denominator };
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
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
            #region Option a
            Console.WriteLine("Задание 1, пункт 'а'. Дописать структуру Complex (добавить метод вычитания)");
            ComplexOptionA firstNumberA;
            ComplexOptionA secondNumberA;
            
            Console.WriteLine("\nВведите два комплексных числа(re - действительная часть, im - мнимая):");
            Console.Write("\nПервое число:\nre = ");
            firstNumberA.re = double.Parse(Console.ReadLine());
            Console.Write("im = ");
            firstNumberA.im = double.Parse(Console.ReadLine());
            Console.Write("\nВторое число:\nre = ");
            secondNumberA.re = double.Parse(Console.ReadLine());
            Console.Write("im = ");
            secondNumberA.im = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nСумма введенных чисел: ({firstNumberA}) + ({secondNumberA}) = {firstNumberA + secondNumberA}");
            Console.WriteLine($"Разность введенных чисел: ({firstNumberA}) - ({secondNumberA}) = {firstNumberA - secondNumberA}");

            NextTask();
            #endregion

            #region Option b
            Console.WriteLine("Задание 1, пункт 'б'. Дописать класс Complex (добавить метод вычитания и произведения)");
            ComplexOptionB firstNumberB = new ComplexOptionB(firstNumberA.re, firstNumberA.im);
            ComplexOptionB secondNumberB = new ComplexOptionB(secondNumberA.re, secondNumberA.im);

            Console.WriteLine($"Введенное вами ранее первое число: {firstNumberB}");
            Console.WriteLine($"Введенное вами ранее второе число: {secondNumberB}");

            Console.WriteLine($"\nСумма введенных чисел: ({firstNumberB}) + ({secondNumberB}) = {firstNumberB + secondNumberB}");
            Console.WriteLine($"Разность введенных чисел: ({firstNumberB}) - ({secondNumberB}) = {firstNumberB - secondNumberB}");
            Console.WriteLine($"Произведение введенных чисел: ({firstNumberB}) * ({secondNumberB}) = {firstNumberB * secondNumberB}");

            #endregion
        }

        static void Task2()
        {
            Console.WriteLine("Задание 2. Пользователь вводит числа, программа считает сумму всех нечетных положительных чисел, и выводит их на экран вместе с суммой.");

            string answer = "";
            int number = 0;
            int sum = 0;

            Console.WriteLine("\nВведите любые целые числа. Для прекращения ввода введите 0:");
            do
            {
                if (int.TryParse(Console.ReadLine(), out number) == true)
                {
                    if (number > 0 && number % 2 != 0)
                    {
                        sum += number;
                        answer += number + ", ";
                    }
                }

                else {
                    Console.WriteLine("Были введены некорректные данные. Пожалуйста, вводите только целые числа");
                    number = 1;
                }
            }
            while (number != 0);

            Console.Write($"\nСумма чисел {answer}\b\b = {sum}");
        }

        static void Task3()
        {
            Console.WriteLine("Задание 3. Описать класс дробей, предусмотреть методы сложения, вычитания, умножения и деления.");
            Fraction firstFraction = new Fraction();
            Fraction secondFraction = new Fraction();

            Console.WriteLine("\nВведите две дроби(знаменатели должны быть больше 0):");
            Console.Write("\nПервое число:\nЧислитель = ");
            firstFraction.Numerator = int.Parse(Console.ReadLine());
            do
            {
                try
                {
                    Console.Write("Знаменатель = ");
                    firstFraction.Denominator = int.Parse(Console.ReadLine());
                }
                catch (DivideByZeroException)
                {
                    Console.Write($"Знаменатель не может быть равен нулю. введите другое значение: ");
                }
            }
            while (firstFraction.Denominator == 0);

            Console.Write("\nВторое число:\nЧислитель = ");
            secondFraction.Numerator = int.Parse(Console.ReadLine());
            do
            {
                try
                {
                    Console.Write("Знаменатель = ");
                    secondFraction.Denominator = int.Parse(Console.ReadLine());
                }
                catch (DivideByZeroException)
                {
                    Console.Write($"Знаменатель не может быть равен нулю. введите другое значение: ");
                }
            }
            while (secondFraction.Denominator == 0);

            Console.WriteLine($"\nСумма введенных дробей: ({firstFraction}) + ({secondFraction}) = {firstFraction + secondFraction}");
            Console.WriteLine($"Разность введенных дробей: ({firstFraction}) - ({secondFraction}) = {firstFraction - secondFraction}");
            Console.WriteLine($"Произведение введенных дробей: ({firstFraction}) * ({secondFraction}) = {firstFraction * secondFraction}");
            try
            {
                Console.WriteLine($"Деление введенных дробей: ({firstFraction}) / ({secondFraction}) = {firstFraction / secondFraction}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на нуль невозможно");
            }
        }

        static void Main(string[] args)
        {
            //Программу написал Критский Сергей
            int task = 0;
            bool stopper = false;

            do
            {
                Console.Write("Введите номер задания от 1 до 3 для просмотра, для выхода введите 0: ");

                if (int.TryParse(Console.ReadLine(), out task) == false) Console.WriteLine("Введены неизвестные символы...");

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
                    }
                }
            } 
            while (stopper == false);
        }
    }
}
