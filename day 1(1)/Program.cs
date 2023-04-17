using System;

class Program
{
    static void Main(string[] args)
    {
        double L, R, S;
        const double PI = Math.PI;

        Console.Write("Введите длину окружности L: ");
        L = double.Parse(Console.ReadLine());


        R = L / (2 * PI);


        S = PI * R * R;

        Console.WriteLine("Радиус окружности R = " + R);
        Console.WriteLine("Площадь круга S = " + S);

        Console.ReadKey();
    }
}