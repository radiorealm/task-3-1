using System;

namespace hw
{
    class JaggedDim
    {
        public OneDim[] array;

        public JaggedDim(int n, bool flag = false)
        {
            array = new OneDim[n];
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

        private void RndEntry(int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = new OneDim(rnd.Next(1, 10), true);
            }
        }
        private void UserEntry(int n)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = new OneDim(int.Parse(Console.ReadLine()));
            }
        }

        public void Show()
        {
            foreach (OneDim el in array)
            {
                el.Show();
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
            int num = 0;
            double summa = 0;

            foreach (OneDim el in array)
            {
                for (int j = 0; j < (el.Array).Length; j++)
                {
                    summa += (el.Array)[j];
                    num++;
                }
            }

            Console.WriteLine($"Среднее значение массива: {summa / num}");
        }

        public void AverageValueMassives()
        {
            Console.WriteLine($"Среднее значение массивов:");

            foreach (OneDim el in array)
            {
                el.AverageValue();
            }
        }
    }
}