using System;


namespace hw
{
    class TwoDim
    {
        int[,] array;

        public TwoDim(int n, int m, bool flag = false)
        {
            array = new int[n, m];

            if (flag)
            {
                RndEntry(n, m);
            }
            else
            {
                UserEntry(n, m);
            }
        }

        public void Input(int n, int m, bool flag = false)
        {
            if (flag)
            {
                RndEntry(n, m);
            }
            else
            {
                UserEntry(n, m);
            }
        }

        private void RndEntry(int n, int m)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                }
            }
        }
        private void UserEntry(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Show()
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

        public void Show_R()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int j1 = i % 2 == 0
                        ? j
                        : array.GetLength(1) - 1 - j;

                    Console.Write(array[i, j1]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}