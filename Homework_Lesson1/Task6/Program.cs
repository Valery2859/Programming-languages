﻿// Написать программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите любое число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) 
{
    Console.WriteLine($"Данное число {a} является чётным");
}
else 
{
    Console.WriteLine($"Данное число {a} не является чётным");
}