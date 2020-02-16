using System;
using BubleSort;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Сортировка пузырьком");
            //Console.Write("Введите элементы массива: ");
            //var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            //var array = new int[parts.Length];
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    array[i] = Convert.ToInt32(parts[i]);
            //}

            //Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", AlgoritmBoobleSort.BubbleSort(array)));

            //Console.ReadLine();

            BoobleSort<int> bobbleSort = new BoobleSort<int>();

            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                bobbleSort.Items.Add(rnd.Next(0, 100));
            }

            for (int i = 0; i < bobbleSort.Items.Count; i++)
            {
                Console.Write(bobbleSort.Items[i] + "\t");
            }

            bobbleSort.Items.Sort();

            Console.WriteLine();
            for (int i = 0; i < bobbleSort.Items.Count; i++)
            {
                Console.Write(bobbleSort.Items[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}
