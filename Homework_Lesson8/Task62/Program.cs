

class Spiral
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите положительное число массива N x N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int s = 1;
        Console.WriteLine("");
        int[,] array = new int[n, n];
        for (int y = 0; y < n; y++)
        {
            array[0, y] = s;
            s++;
        }
        for (int x = 1; x < n; x++)
        {
            array[x, n - 1] = s;
            s++;
        }
        for (int y = n - 2; y >= 0; y--)
        {
            array[n - 1, y] = s;
            s++;
        }
        for (int x = n - 2; x > 0; x--)
        {
            array[x, 0] = s;
            s++;
        }
        int c = 1;
        int d = 1;

        while (s < n * n)
        {
            while (array[c, d + 1] == 0)
            {
                array[c, d] = s;
                s++;
                d++;
            }
            while (array[c + 1, d] == 0)
            {
                array[c, d] = s;
                s++;
                c++;
            }
            while (array[c, d - 1] == 0)
            {
                array[c, d] = s;
                s++;
                d--;
            }
            while (array[c - 1, d] == 0)
            {
                array[c, d] = s;
                s++;
                c--;
            }
        }
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                if (array[x, y] == 0)
                {
                    array[x, y] = s;
                }
            }
        }
        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                if (array[x, y] < 10)
                {
                    Console.Write(array[x, y] + "  ");
                }
                else
                {
                    Console.Write(array[x, y] + " ");
                }
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}