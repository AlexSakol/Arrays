internal class Program
{
    private static void Task3(ref int[][] massiv) // Calculate sum of even positive elements in columns
    {
        var n = massiv[0].Length;
        int[] mas1 = new int[n];
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (massiv[i][j] > 0 & massiv[i][j] % 2 == 0)
                {
                    sum += massiv[i][j];
                }
            }
            mas1[j] = sum;
        }
        Console.WriteLine("Сумма четных положительных элементов");
        foreach (int i in mas1)
        {
            Console.Write($"{i}\t");
        }
    }

    private static void Main(string[] args)
    {
        try
        {
            Random Rand = new Random();
            Console.WriteLine("Введите максимальное значение");
            int Max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минимальное значение");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());       
            int[][] mas = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int m = Rand.Next(1, n);
                mas[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    mas[i][j] = Rand.Next(Min, Max);
                }
            }
            Console.WriteLine("Создан массив");
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    Console.Write($"{mas[i][j]}\t");
                }
                Console.WriteLine();
            }
            var columns = mas[0].Length;
            for (int i = 0; i < n; i++)
            {
                if (mas[i].Length > columns)
                {
                    columns = mas[i].Length;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Array.Resize(ref mas[i], columns);
            }
            Task3(ref mas);
        }
        catch
        {
            Console.WriteLine("Невозможно создать массив");
        }
    }
}
