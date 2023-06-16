using System;

class Program
{
    static void Main()
    {
        int x = GetNumber("Podaj liczbę x: ");

        int n = FindFactorialNumber(x);

        if (n != -1)
        {
            Console.WriteLine($"{x} jest silnią liczby {n}.");
        }
        else
        {
            Console.WriteLine($"{x} nie jest silnią żadnej liczby.");
        }

        Console.ReadKey();
    }

    static int FindFactorialNumber(int x)
    {
        int n = 0;
        int factorial = 1;

        while (factorial <= x)
        {
            if (factorial == x)
            {
                return n;
            }

            n++;
            factorial *= n;
        }

        return -1;
    }

    static int GetNumber(string message)
    {
        int number;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out number) && number >= 0)
            {
                break;
            }
            Console.WriteLine("Błędne dane. Podaj liczbę naturalną.");
        }

        return number;
    }
}
