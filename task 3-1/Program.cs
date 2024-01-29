using System;

namespace inheritance
{
    class Program
    {
        static void Main()
        {
            Parent[] arr = new Parent[3];

            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите способ ввода для всех массивов (false, если случайно, true, если вручную)");
            bool entry = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            OneDim onedim = new(n, entry);

            Console.WriteLine("Введите m для двумерного массива:");
            TwoDim twodim = new(n, int.Parse(Console.ReadLine()), entry);
            Console.WriteLine();

            JaggedDim jaggeddim = new(n, entry);

            arr[0] = onedim;
            arr[1] = twodim;
            arr[2] = jaggeddim;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Массив {arr[i].GetType()}:");
                arr[i].Print();
                Console.WriteLine();

                Console.WriteLine($"Его среднее значение: {arr[i].AverageValue()}");
                Console.WriteLine();
            }
        }
    }

}
