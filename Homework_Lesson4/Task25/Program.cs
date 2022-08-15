// Написать цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


using System;
 
class Program {
 public static int Main() 
 {  
  Console.Write("Введите число: ");   //число, которое нужно возвести в степень
  int a = Convert.ToInt32(Console.ReadLine());
  
  Console.Write("Введите степень: "); //степень числа
  int b = Convert.ToInt32(Console.ReadLine());
  
  int result=1;                       //число, возведенное в степень
  for(int i=0; i<b; i++) 
  {
   result *= a;
  }
  Console.WriteLine("{0}^{1} = {2}", a, b, result);
  Console.ReadKey();
  return 0;
 }
}
