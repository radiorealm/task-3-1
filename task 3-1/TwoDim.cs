using System;


namespace inheritance
{
    sealed class TwoDim : Parent
    {
        int m;

        int[,] array;

        public TwoDim(int n, int m, bool entry = false) : base(n, entry)
        {
            array = new int[n, m];

            this.m = m;

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
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                }
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите значения массива вручную");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
        }

        public override void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public override double AverageValue()
        {
            double summa = 0;

            foreach (int el in array)
            {
                summa += el;
            }

            return (summa / array.Length);
        }
    }

}