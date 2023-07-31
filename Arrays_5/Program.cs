//Get a string of 5 elements and 5 chars and write chars in the string 

internal class Program
{
    private static bool ConvertChar(string s, ref char c1, ref char c2, ref char c3, ref char c4, ref char c5)
    {
        if (s.Length == 5)
        {
            c1 = s[0];
            c2 = s[1];
            c3 = s[2];
            c4 = s[3];
            c5 = s[4];
            return true;
        }
        else
        {
            Console.WriteLine("Длина строки не равна 5");
            return false;
        }
    }
    internal static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательно пять букв через enter");
        char ch1 = Convert.ToChar(Console.ReadLine());
        char ch2 = Convert.ToChar(Console.ReadLine());
        char ch3 = Convert.ToChar(Console.ReadLine());
        char ch4 = Convert.ToChar(Console.ReadLine());
        char ch5 = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Введите строку из пяти символов");
        string str = Console.ReadLine();
        if (ConvertChar(str, ref ch1, ref ch2, ref ch3, ref ch4, ref ch5) != false)
        {
            Console.WriteLine($"{ch1}, {ch2}, {ch3}, {ch4}, {ch5}");
        }
    }
}
