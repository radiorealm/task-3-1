using System;

namespace inheritance
{
    sealed class OneDim : Parent
    {
        int[] array;

        public int[] Array
        {
            get { return array; }
        }

        public OneDim(int n, bool entry = false) : base(n, entry)
        {
            array = new int[n];

            if (!entry)
            {
                RndEntry();
            }
            else
            {
                UserEntry();
            }
        }

        public override void RndEntry()
        {;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите значения массива вручную");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
        }

        public override double AverageValue()
        {
            double summa = 0;
            foreach (int el in array)
            {
                summa += el;
            }
            return summa / array.Length;
        }

        public override void Print()
        {
            Console.WriteLine(String.Join(" ", array));
        }
    }

}