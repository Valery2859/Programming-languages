﻿// Написать программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число ");
 int a = Convert.ToInt32( Console.ReadLine() );
     Console.Write("Вторая цифра этого числа - " + a % 100/10);
     Console.WriteLine(" ");

