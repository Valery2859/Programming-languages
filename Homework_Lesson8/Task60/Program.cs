//  ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine($"Введите размер массива X x Y x Z: ");
        Console.Write("Введите X: ");
        int X = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите Y: ");
        int Y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите Z: ");
        int Z = Convert.ToInt32(Console.ReadLine());
        int[,,] array = new int[X, Y, Z];
        Console.WriteLine();
        int chislo = new Random().Next(10, 100);
        int granica = 99;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int n = 0; n < array.GetLength(2); n++)
                {
                    array[i, j, n] = chislo;
                    if (chislo >= array[0, 0, 0] && chislo <= granica)
                    {
                        chislo++;
                    }
                    else
                    {
                        chislo--;
                    }
                    if (chislo > granica)
                    {
                        chislo = array[0, 0, 0] - 1;
                    }
                }

            }
        }
        int temp = 0, i1 = 0, j1 = 0, n1 = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            i1 = new Random().Next(0, array.GetLength(0));
            for (int j = 0; j < array.GetLength(1); j++)
            {
                j1 = new Random().Next(0, array.GetLength(1));
                for (int n = 0; n < array.GetLength(2); n++)
                {
                    n1 = new Random().Next(0, array.GetLength(2));
                    temp = array[i1, j1, n1];
                    array[i1, j1, n1] = array[i, j, n];
                    array[i, j, n] = temp;
                }
            }
        }
        Console.WriteLine("Введенный 3D-массив:");
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int n = 0; n < array.GetLength(2); n++)
                {
                    Console.Write($"{array[i, j, n]}({i},{j},{n}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}