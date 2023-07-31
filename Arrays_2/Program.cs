// Меняет местами два средних столбца, если количество столбцов четное,
// и первый со средним столбцом, если количество столбцов нечетное.

namespace ConsoleApplication1
{
    class Program
    {
        static void Task2(ref int[,] mas)
        {
            int size = mas.GetUpperBound(0) + 1;
            int[] temp = new int[size];
            var median = size / 2;
            Console.WriteLine();
            if (size % 2 == 0)
            {
                Console.WriteLine("Количество столбцов четное");
                for (int i = 0; i < size; i++)
                {
                    temp[i] = mas[i, median];
                    mas[i, median] = mas[i, median - 1];
                    mas[i, median - 1] = temp[i];
                }
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"{mas[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            if (size % 2 != 0)
            {
                Console.WriteLine("Количество столбцов нечетное");
                for (int i = 0; i < size; i++)
                {
                    temp[i] = mas[i, median];
                    mas[i, median] = mas[i, 0];
                    mas[i, 0] = temp[i];
                }
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"{mas[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Random Rand = new Random();
                Console.WriteLine("Введите максимальное значение");
                int max = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минимальное значение");
                int min = Convert.ToInt32(Console.ReadLine());            
                Console.WriteLine("Введите размерность массива");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] massiv = new int[n, n];
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        massiv[i, j] = Rand.Next(min, max + 1);
                        Console.Write($"{massiv[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                Task2(ref massiv);
            }
            catch
            {
                Console.WriteLine("Невозможно создать массив");
            }
            Console.ReadKey();
        }
    }
}
