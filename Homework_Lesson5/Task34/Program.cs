// Задать массив заполненный случайными положительными трёхзначными числами. 
// Написать программу, которая покажет количество чётных чисел в массиве.

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива");
        int size = Convert.ToInt32( Console.ReadLine() ); 
        int[] array = new int[size];
        Random myRandom = new Random(); 
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = myRandom.Next(100,900+size);
            Console.Write("{0} ", array[i]);
            if (array[i] % 2 == 0)
            {
                result += 1;
            }
        } 
        Console.Write(" --> {0} чётных", result);
        Console.WriteLine(" ");
    }
}