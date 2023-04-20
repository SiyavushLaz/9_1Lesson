using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        if (n < 1)
            return;
        Console.Write("{0} ", n);
        PrintNumbers(n - 1);
    }
}
