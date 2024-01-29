using System;

namespace hw
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите тип массива (1, если одномерный, 2, если двумерный и 3, если ступенчатый)");
            int clas = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите способ ввода (true, если рандомно, false, если вводите вручную)");
            bool entry = bool.Parse(Console.ReadLine());
            switch (clas)
            {
                case 1:
                    Console.WriteLine("Введите количество элементов в массиве (целое число)");
                    OneDim onedim = new OneDim(int.Parse(Console.ReadLine()), entry);
                    onedim.Print();
                    break;

                case 2:
                    Console.WriteLine("Введите количество строк в массиве (целое число)");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество столбцов в массиве (целое число)");
                    TwoDim twodim = new TwoDim(n, int.Parse(Console.ReadLine()), entry);
                    twodim.Show();
                    Console.WriteLine();
                    twodim.Show_R();
                    break;

                case 3:
                    Console.WriteLine("Введите количество строк в массиве (целое число)");
                    JaggedDim jaggeddim = new JaggedDim(int.Parse(Console.ReadLine()), entry);
                    jaggeddim.Show();
                    jaggeddim.AverageValue();
                    jaggeddim.AverageValueMassives();
                    jaggeddim.MultiplyIndex();
                    jaggeddim.Show();
                    break;
            }
        }
    }
}
