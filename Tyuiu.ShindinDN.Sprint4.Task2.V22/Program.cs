using Tyuiu.ShindinDN.Sprint4.Task2.V22.Lib;

namespace Tyuiu.ShindinDN.Sprint4.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Шиндин Д. Н. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Шиндин Денис Николаевич | ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 6 подсчитать произведение нечетных       *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов массива: ");
            Random rnd = new Random();
            int[] nums = new int[13];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 6+1);
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(nums);
            Console.WriteLine(res);
        }
    }
}
