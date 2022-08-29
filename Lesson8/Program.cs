// Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сторону а: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сторону b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сторону c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Треугольник существует");
        }
        else
        {
            Console.WriteLine("Треугольник не существует");
        }
    }
}