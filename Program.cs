using System;

class Program
{

    static void Main()
    {
        const double a = 2.0;
        const double b = 1.0;
        const double c = 3.0;
        const double x = -1.5;

        double numerator = (a * Math.Pow(x, 3)) + ((5.0 / 2) * b * Math.Sqrt(Math.Pow(x, 2) + 1));
        double denumerator = c + Math.Sin(x) * Math.Cos(x);
        if (denumerator == 0)
        {
            Console.WriteLine("Ошибка деления на ноль!!!");
            return;
        }
        double result = numerator / denumerator;
        Console.WriteLine($"Результат вычесления фугкций при задданых числах:");
        Console.WriteLine($"y={result}");
    }   
}