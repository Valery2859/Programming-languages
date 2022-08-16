// Написать программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

class Program 
{
  static void Main()
 {  
    Console.WriteLine("Введите любое число ");
    int a = Convert.ToInt32( Console.ReadLine() );
    int b = a;
    int d = 0; // кол-во цифр в числе
    while (b > 0)
    {
        d++;
        b = (int)(b/10);
    }
    if (d<2)
    {
        Console.WriteLine("Сумма цифр в числе {0} -> {1}", a, a);    
    }
    else 
    {
        int result = 0;
        for(int i = 1; i <= d; i++)
        {
            int c = (int) Math.Pow(10,i);
            result = result + (a % c /(c/10));
        }
        Console.WriteLine("Сумма цифр в числе {0} -> {1}", a, result);
        Console.WriteLine(" ");
    }
  }
}