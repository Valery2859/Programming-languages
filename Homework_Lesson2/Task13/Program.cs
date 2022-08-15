// Написать программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет. 

Console.WriteLine(" ");
Console.WriteLine("Введите число ");
 int a = Convert.ToInt32( Console.ReadLine() );    
    
int b = a;
int d = 0; // кол-во цифр
while (b > 0)
{
  d++;
  b = (int)(b/10);
}    
if (d<3)
{
  Console.WriteLine("Третьей цифры нет ");    
}
else 
{
 d -= 2;
 int c = (int) Math.Pow(10,d);
 if (c < 100)
 {
    Console.Write("Третья цифра этого числа - " + a % c);
 }
 else
 {
    Console.WriteLine("Третья цифра этого числа - " + a % c /(c/10));
 }
 Console.WriteLine(" ");
}