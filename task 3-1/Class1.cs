using System;
using System.Linq;

namespace hw
{
    class OneDim
    {
        public int[] array;

        public OneDim(int n, bool flag = false)
        {
            if (flag)
            {
                RndEntry(n);
            }
            else
            {
                UserEntry(n);
            }
        }

        private void RndEntry(int x)
        {
            Random rnd = new Random();
            int[] arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            array = arr;
        }
        private void UserEntry(int x)
        {
            int[] arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            array = arr;
        }

        private double AverageValue(int[] Array)
        {
            double summa = 0;
            foreach (int el in Array)
            {
                summa += el;
            }
            return summa / Array.Length;
        }

        private int[] ElementsLessHundred(int[] Array)
        {
            int n = Array.Length;
            foreach (int el in Array)
            {
                if (Math.Abs(el) > 100)
                {
                    n = n - 1;
                }
            }
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (array[i] <= 100)
                {
                    arr[i] = Array[i];
                }
            }
            return arr;
        }

        private int[] DeleteDublicates(int[] Array)
        {
            int[] unique = Array.Distinct().ToArray();
            return unique;
        }

        public void Print()
        {
            Console.WriteLine($"Среднее значение массива: {AverageValue(array)}");
            Console.WriteLine(String.Join(" ", array));

            int[] arr1 = ElementsLessHundred(array);
            Console.WriteLine("Элементы, меньшие 100");
            Console.WriteLine(String.Join(" ", arr1));

            int[] arr2 = DeleteDublicates(array);
            Console.WriteLine("Уникальные элементы (без повторяющихся элементов)");
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}