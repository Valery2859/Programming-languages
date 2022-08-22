// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        Random myRandom = new Random();
         int max=99, min=10, result = 0;
         for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0,0 + size);              
                Console.Write("{0} ", array[i]);
                if ( array[i] < max && array[i] > min) result += 1;
                               
            } 
            Console.WriteLine(" ");
            Console.WriteLine("Количество элементов массива между {0} и {1} -> {2}", min, max, result);
            Console.WriteLine(" ");  

    }
}