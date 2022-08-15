// Написать программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<=n; i++)
{
    int a = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write("{0} ", a);
}
Console.WriteLine(" ");
