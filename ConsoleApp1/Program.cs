using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task8();
        }

        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        public static void Task1()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);
        }

        /// <summary>
        /// Найти два наибольших элемента массива
        /// </summary>
        public static void Task2()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int max = a[0];
            int max2 = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max2 = max;
                    max = a[i];
                }

                if (max2 < a[i] && a[i] != max)
                {
                    max2 = a[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(max2);
        }

        /// <summary>
        /// Посчитать сумму элементов массива
        /// </summary>
        public static void Task3()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int Sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Sum += a[i];
            }

            Console.WriteLine(Sum);
        }

        /// <summary>
        /// Заполнить массив по возрастанию от 1 до 100
        /// </summary>
        public static void Task4()
        {
            int[] mas = new int[100];
            for (int i = 0; i < 100; i++)
            {
                mas[i] = i + 1;
                Console.WriteLine(mas[i]);
            }
        }

        /// <summary>
        /// Создать и заполнить массив случайными целыми числами
        /// </summary>
        public static void Task5()
        {
            //пример вызова генератора случайных чисел, он понадобится в данной задаче
            Random rnd = new Random();
            //int r = rnd.Next(1, 10);//случайное число от 1 до 10

            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = rnd.Next(1, 10);
                Console.WriteLine(mas[i]);
            }
        }

        /// <summary>
        /// Проверить, что в массиве нет одинаковых чисел
        /// </summary>
        public static void Task6()
        {
            int[] mas = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            bool result = false;

            for (int i = 0; i < mas.Length / 2; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] == mas[j])
                    {
                        Console.WriteLine($"Да одинаковые числа есть. Это { mas[j] }");
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    break;
                }
            }
            if (!result)
            {
                Console.WriteLine("Одинаковых чисел нет.");
            }
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке используя вспомогательный массив
        /// </summary>
        public static void Task7()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[a.Length-i-1];
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] +" ");
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
        }

        /// <summary>
        /// Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
        /// </summary>
        public static void Task8()
        {
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            Console.WriteLine("Начальный массив");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length/2; i++)
            {
                int t = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = t;
            }
            Console.WriteLine("Результирующий массив");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Подсчитать сумму чисел в двухмерном массиве
        /// </summary>
        public static void Task9()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
        }

        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
        /// </summary>
        public static void Task10()
        {
        }

        /// <summary>
        /// Двумерный массив скопировать в одномерный
        /// </summary>
        public static void Task11()
        {
            int[,] m = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
        }


        /// <summary>
        /// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
        /// </summary>
        public static void Task12()
        {
            //подсказка: для определения остатка от деления используется оператор %
            int ostatok = 4 % 2; //будет равен нулю
        }
    }
}
