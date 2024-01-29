using System;

namespace hw
{
    class JaggedDim
    {
        public int[][] array;

        public JaggedDim(int n, bool flag = false)
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

        private void RndEntry(int n)
        {
            Random rnd = new Random();
            int[][] ans = new int[n][];
            int[] s;
            for (int i = 0; i < n; i++)
            {
                s = new int[rnd.Next(1, 10)];
                ans[i] = new int[s.Length];
                for (int j = 0; j < s.Length; j++)
                {
                    ans[i][j] = rnd.Next(1, 100);
                }
            }
            array = ans;
        }
        private void UserEntry(int n)
        {
            int[][] ans = new int[n][];
            string[] s;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите в строчку через пробел значения для строки {i}");
                s = Console.ReadLine().Split(' ');
                ans[i] = new int[s.Length];
                for (int j = 0; j < s.Length; j++)
                {
                    ans[i][j] = int.Parse(s[j]);
                }
            }
            array = ans;
        }

        public void Show()
        {
            foreach (int[] m in array)
            {
                foreach (int el in m)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
            }
        }

        public void MultiplyIndex()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
        }

        public void AverageValue()
        {
            int n = 0;
            double summa = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    summa += array[i][j];
                    n++;
                }
            }
            Console.WriteLine($"Среднее значение массива: {summa / n}");
        }

        public void AverageValueMassives()
        {
            double summa = 0;
            for (int i = 0; i < array.Length; i++)
            {
                foreach (int el in array[i])
                {
                    summa += el;
                }
                Console.WriteLine($"Среднее значение массива {i + 1}: {summa / array[i].Length}");
                summa = 0;
            }
            Console.WriteLine();
        }
    }
}