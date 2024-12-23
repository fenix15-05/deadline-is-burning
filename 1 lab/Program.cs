using System;

class Program
{
    static void Main(string[] args)
    {
        double A = 0, B = 0, C = 0;

        // Проверка аргументов командной строки
        if (args.Length == 3)
        {
            if (!double.TryParse(args[0], out A))
            {
                Console.WriteLine("Некорректное значение коэффициента A. Используйте ввод с клавиатуры.");
            }
            if (!double.TryParse(args[1], out B))
            {
                Console.WriteLine("Некорректное значение коэффициента B. Используйте ввод с клавиатуры.");
            }
            if (!double.TryParse(args[2], out C))
            {
                Console.WriteLine("Некорректное значение коэффициента C. Используйте ввод с клавиатуры.");
            }
        }

        // Если коэффициенты не были заданы или некорректные, запрашиваем ввод
        while (A == 0 || B == 0 || C == 0)
        {
            if (A == 0)
            {
                Console.Write("Введите коэффициент A: ");
                double.TryParse(Console.ReadLine(), out A);
            }
            if (B == 0)
            {
                Console.Write("Введите коэффициент B: ");
                double.TryParse(Console.ReadLine(), out B);
            }
            if (C == 0)
            {
                Console.Write("Введите коэффициент C: ");
                double.TryParse(Console.ReadLine(), out C);
            }
        }

        // Вычисление дискриминанта
        double D = B * B - 4 * A * C;
        Console.WriteLine($"Дискриминант: {D}");

        // Вывод корней уравнения
        if (D < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Корней нет.");
        }
        else if (D == 0)
        {
            double root = -B / (2 * A);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Уравнение имеет один корень: {root}");
        }
        else
        {
            double root1 = (-B + Math.Sqrt(D)) / (2 * A);
            double root2 = (-B - Math.Sqrt(D)) / (2 * A);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Уравнение имеет два корня: {root1} и {root2}");
        }

        // Сброс цвета консоли
        Console.ResetColor();
    }
}