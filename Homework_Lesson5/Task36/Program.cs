// Задать одномерный массив, заполненный случайными числами. Найти сумму 
// элементов, стоящих на нечётных позициях.

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива");
        int size = Convert.ToInt32( Console.ReadLine() ); 
        int[] array = new int[size];
        Random myRandom = new Random(); 
        int result = 0;
        int n = 1;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = myRandom.Next(-100,100 + size);
            Console.Write("{0} ", array[i]);
            if ( i == n)
            {
                result += array[i];
                n += 2;
            }
        } 
        Console.Write(" --> {0}, сумма элементов на не чётных позициях", result);
        Console.WriteLine(" ");
    }
}