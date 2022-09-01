// Задайте значения M и N. Напишите программу, которая выведет все натуральные
// числа в промежутке от M до N.

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Задайте значения M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Задайте значения N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (m > n)
        {
            Console.WriteLine("Число М не может быть больше числа N  ");
            Console.WriteLine("");
            return;
        }
        int k = 0;
        int[] array = new int[n + 1];
        Console.Write("M = {0}, N = {1} -> ", m, n);
        for (int i = m; i < n + 1; i++)
        {
            array[i] += i;
            k += i;
            Console.Write("{0} ", array[i]);
            Thread.Sleep(100);
        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
}