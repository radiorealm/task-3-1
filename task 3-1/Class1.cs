using System;
using System.Linq;

namespace hw
{
    class OneDim
    {
        int[] array;

        public int[] Array
        {
            get { return array; }
        }

        public int Length
        {
            get { return array.Length; }
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public OneDim(int n, bool flag = false)
        {
            array = new int[n];

            if (flag)
            {
                RndEntry(n);
            }
            else
            {
                UserEntry(n);
            }
        }

        public void Input(int n, bool flag = false)
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

            for (int i = 0; i < x; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
        }
        private void UserEntry(int x)
        {
            for (int i = 0; i < x; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public double AverageValue()
        {
            double summa = 0;
            foreach (int el in array)
            {
                summa += el;
            }
            return summa / array.Length;
        }

        private int[] ElementsLessHundred()
        {
            int n = array.Length;
            foreach (int el in array)
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
                    arr[i] = array[i];
                }
            }
            return arr;
        }

        private int[] DeleteDublicates()
        {
            int[] unique = array.Distinct().ToArray();
            return unique;
        }

        public void Show()
        {
            Console.WriteLine(String.Join("", array));
        }
        public void Print()
        {
            Console.WriteLine($"Среднее значение массива: {AverageValue()}");;

            Show();

            int[] arr1 = ElementsLessHundred();
            Console.WriteLine("Элементы, меньшие 100");
            Console.WriteLine(String.Join(" ", arr1));

            int[] arr2 = DeleteDublicates();
            Console.WriteLine("Уникальные элементы (без повторяющихся элементов)");
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}