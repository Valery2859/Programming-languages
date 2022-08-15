// Написать программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.

int a, b, a1 = 0;
Console.WriteLine("Введите первое число");
 a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
 b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
 a1 = Convert.ToInt32(Console.ReadLine());
if (a > b && a > a1)
{
    Console.WriteLine($"Первое число {a} максимальное из этих чисел");
}
else if (b > a && b > a1) 
{
    Console.WriteLine($"Второе число {b} максимальное из этих чисел");
}
else 
{
    Console.WriteLine($"Третье число {a1} максимальное из этих чисел");
}