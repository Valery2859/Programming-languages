// Напишите программу, которая задаёт массив из N элементов
// и выводит их на экран

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива");
        int size = Convert.ToInt32( Console.ReadLine() ); 
        int[] array = new int[size];
        Random myRandom = new Random(); 
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = myRandom.Next(0, size);
            Console.Write("{0} ", array[i]);
        } 
        Console.WriteLine(" ");
    }
}