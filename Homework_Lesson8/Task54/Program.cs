// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

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
                array[i, j] = myRandom.Next(0, 10 + n);
                Console.Write("{0}\t", array[i, j]);
            }
            Console.WriteLine(" ");
        }
        int indx; //переменная для хранения индекса максимального элемента массива        
        for (int k = 0; k < m; k++)
        {
            for (int i = 0; i < n; i++) //проходим по массиву с начала и до конца
            {
                indx = i; //считаем, что максимальный элемент имеет текущий индекс 
                for (int j = i; j < n; j++) //ищем максимальный элемент в неотсортированной части
                {
                    if (array[k, j] > array[k, indx])
                    {
                        indx = j; //нашли в массиве число больше, чем array[k,indx] - запоминаем его индекс в массиве
                    }
                }
                if (array[k, indx] == array[k, i]) //если максимальный элемент равен текущему значению - ничего не меняем
                    continue;
                //меняем местами максимальный элемент и первый в неотсортированной части
                int temp = array[k, i]; //временная переменная, чтобы не потерять значение array[k,i]
                array[k, i] = array[k, indx];
                array[k, indx] = temp;
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Отсортированный массив:");
        Console.WriteLine(" ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}\t", array[i, j]);
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
    }
}
