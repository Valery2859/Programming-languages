// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите количество строк m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество элементов массива в строке n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[m, n];
        Random myRandom = new Random();
        Console.WriteLine(" ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = myRandom.Next(-10, 10 + n);
                Console.Write("{0}\t", array[i, j]);
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
        Console.WriteLine("Введите строку массива m: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите столбец массива n: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > m - 1 | b > n - 1) { Console.WriteLine("такого числа нет"); }
        else
        {
            Console.WriteLine(array[a, b]);
        }
    }
}

