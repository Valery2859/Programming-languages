// Написать программу, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.

int b = 0;
Console.WriteLine("Введите число N");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    if (i%2==0)
    {
        b += 2;
        Console.Write("{0} ", b);
    }    
}
