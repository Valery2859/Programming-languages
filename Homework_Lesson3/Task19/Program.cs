// Написать программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.


Console.WriteLine("Введите пятизначное число ");
int a = Convert.ToInt32( Console.ReadLine() );

if (a % 100000/10000 == a % 10)
{

    if (a % 10000/1000 == a % 100/10)
    {
        Console.Write(a + " -> Число является палиндромом ");
        Console.WriteLine(" ");
    }
}
else 
{
    Console.Write(a + " -> Число не является палиндромом ");
    Console.WriteLine(" ");
}