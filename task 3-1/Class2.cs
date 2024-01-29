using System;


namespace hw
{
    class TwoDim
    {
        public int[,] array;

        public TwoDim(int n, int m, bool flag = false)
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
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(1, 100);
                }
            }
            array = arr;
        }
        private void UserEntry(int n, int m)
        {
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            array = arr;
        }

        public void Show()
        {
            int r = array.GetLength(1);
            foreach (int i in array)
            {
                Console.Write(i);
                r = r - 1;
                if (r == 0)
                {
                    Console.WriteLine();
                    r = array.GetLength(1);
                }
                else
                {
                    Console.Write(" ");
                }
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