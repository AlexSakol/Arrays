class Program
{
    static void Task1(int[] mas)
    {
        Console.WriteLine();
        Console.WriteLine("7. Подсчитать сумму элементов, расположенных между максимальным и минимальным элементами(если таких элементов несколько – взять первые из них.");
        int i1 = Array.IndexOf(mas, mas.Max());
        int i2 = Array.IndexOf(mas, mas.Min());
        if (i1 > i2)
        {
            Console.WriteLine("Минимальный элемент расположен перед максимальным. Невозможно найти решение");
        }
        else
        {
            int sum = 0;
            for (int i = i1 + 1; i < i2; i++)
            {
                sum += mas[i];
            }
            Console.WriteLine($"Сумма элементов расположенных между первым максимальным и первым минимальным элементами {sum}");
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
            Console.WriteLine("Введите количество элементов");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int[n];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = Rand.Next(min, max + 1);
                Console.Write($"{massiv[i]}\t");
            }
            Task1(massiv);
        }
        catch
        {
            Console.WriteLine("Невозможно создать массив");
        }
        Console.ReadKey();
    }
}
