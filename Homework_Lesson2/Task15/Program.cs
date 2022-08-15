// Написать программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

 int b = 0;
 Console.WriteLine("Введите цифру дня недели ");
while (true)
{    
 int a = Convert.ToInt32( Console.ReadLine() );
 if (a > 0 && a < 8)
 {
    b = a;
    break;
 }
 Console.WriteLine("Введите цифру от 1 до 7 ");
}
if (b < 6)
{
    Console.WriteLine(b + " --> этот день не выходной ");
}
else 
{
    Console.WriteLine(b + " --> этот день выходной ");
}

