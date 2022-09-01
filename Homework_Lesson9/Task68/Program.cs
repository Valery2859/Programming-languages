// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

class Program
{
    static int A(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m > 0 && n == 0) return A(m - 1, 1);
            return A(m - 1, A(m, n - 1));
        }
    static void Main()
    {        
        Console.Clear();
        Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии.");
        Console.WriteLine("Задать два неотрицательных числа m и n.");
        Console.WriteLine(" ");
        Console.Write("Первое число m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Второе число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("A({0},{1}) = {2}", m, n, A(m, n));
        Console.WriteLine(" ");
    }
}