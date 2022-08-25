// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите количество строк m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество элементов массива в строке n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[,] array = new double[m, n];
        Random myRandom = new Random();
        Console.WriteLine(" ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = myRandom.Next(-10, 10 + n) + myRandom.NextDouble();
                Console.Write("{0:F1}\t ", array[i, j]);
            }
            Console.WriteLine(" ");

        }
        Console.WriteLine(" ");
    }
}

