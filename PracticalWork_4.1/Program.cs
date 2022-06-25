using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1. Случайная матрица
            //Console.WriteLine("Создаём матрицу заданного размера, выводим на экран и считаем сумму всех элементов");
            //Console.Write($"\nВведите необходимое количеств строк: ");
            //int Lines = int.Parse(Console.ReadLine());

            //Console.Write($"Введите необходимое количество столбцов: ");
            //int Colums = int.Parse(Console.ReadLine());

            //int[,] Array = new int[Lines, Colums];
            //Random random = new Random();
            //int Sum = 0;

            //for (int i = 0; i < Lines; i++)
            //{
            //    for (int j = 0; j < Colums; j++)
            //    {
            //        Array[i, j] = random.Next(100);
            //        Sum += Array[i, j];
            //        Console.Write($"{Array[i, j],3} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"\nСумма всех элементов: {Sum}");
            //Console.ReadLine();
            #endregion



            #region Задание 2. Наименьший элемент в последовательности
            //Console.WriteLine("Выводим на экран заданную последовательность чисел и находим наименьшее значение.");
            //Console.Write("\nВведите длину последовательности: ");
            //int[] Array = new int[int.Parse(Console.ReadLine())];

            //int min = int.MaxValue;

            //for (int i = 0; i < Array.Length; i++)
            //{
            //    Console.Write($"\nВведите любое целое значение {i + 1}-го элемента: ");
            //    Array[i] = int.Parse(Console.ReadLine());
            //    if (Array[i] < min) min = Array[i];
            //}
            //Console.Write("\nПолучившаяся последовательность: ");

            //for (int i = 0; i < Array.Length; i++)
            //    Console.Write($"{Array[i]}  ");

            //Console.WriteLine($"\nМинимальное значение данной последовательности: {min}");

            //Console.ReadLine();
            #endregion



            #region Задание 3. Игра "Угадай число"
            //Console.WriteLine("Вводим максимальное число nMax, затем угадываем сгенерированное от 0 до N число,\nиспользуя подсказки. Для окончания игры жмем клавишу 'пробел'");
            //Console.WriteLine($"\nУкажите максимальное число диапазона: ");
            //int nMax = int.Parse(Console.ReadLine());
            //Random random = new Random();
            //int nHidden = random.Next(nMax);

            //while (true)
            //{
            //    Console.Write("Введите Ваш вариант: ");
            //    string nVersion = Console.ReadLine();
            //    if (nVersion == " ")
            //    {
            //        Console.WriteLine($"Жаль, что Вы не сумели угадать число. Загаданное число: {nHidden}");
            //        break;
            //    }
            //    else
            //    {
            //        if (nHidden == Convert.ToInt32(nVersion))
            //        {
            //            Console.WriteLine("Поздравляем, Вы угадали число!");
            //            break;
            //        }
            //        else
            //        {
            //            if (nHidden > Convert.ToInt32(nVersion)) Console.Write("\nВаше число меньше загаданного. Попробуйте снова. ");
            //            else  Console.Write("\nВаше число больше загаданного. Попробуйте снова. ");
            //        }
            //    }
            //}
            //Console.ReadLine();
            #endregion
        }
    }
}
