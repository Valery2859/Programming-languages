// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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
        int result = 1;                //переменная для хранения строки с наименьшей суммой элементов
        int temp1 = 0, temp2 = 0;      // переменные для хранения суммы элементов        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++) //проходим по массиву с начала и до конца
            {
                if (i == 0)
                {
                    temp2 += array[i, j];
                    temp1 = temp2;       //сохраняем сумму первой строки
                } 
                else { temp2 += array[i, j]; } //считаем суммы следующих строк              
            }
            if (temp1 > temp2) //сравниваем суммы строк
            {
                result = i + 1;
                temp1 = temp2;
                temp2 = 0;
            }
            temp2 = 0;
        }
        Console.WriteLine(" ");
        Console.Write("строка с наименьшей суммой элементов: {0}", result);//выводим результат
        Console.WriteLine(" ");
        Console.WriteLine(" ");
    }
}
