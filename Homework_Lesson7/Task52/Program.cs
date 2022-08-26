// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.

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
                array[i, j] = myRandom.Next(0, 20 + n);
                Console.Write("{0}\t", array[i, j]);
            }
            Console.WriteLine(" ");
        }
        double a = 0;
        int b = 0;
        Console.Write("среднее арифметическое каждого столбца: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a += array[j, i];
            }
                Console.Write("{0:F1}; ", a / m);
            
            a = 0;
        }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
}