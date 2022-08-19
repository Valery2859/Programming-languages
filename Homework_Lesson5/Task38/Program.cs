// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int size = Convert.ToInt32( Console.ReadLine() ); 
            double[] array = new double[size];
            Random myRandom = new Random();
            double max=0, min=100;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] =100 - myRandom.Next(100+size) + myRandom.NextDouble();                
                Console.Write("{0:F0} ", array[i]); // Округляем вещественные числа до целых
                if ( array[i] > max) max = array[i];
                if ( array[i] < min) min = array[i];               
            } 
            Console.WriteLine(" ");
            Console.WriteLine("Разница между максимальным {0:F0} и минимальным {1:F0} = {2:F0}",max,min,(max - min));
            Console.WriteLine(" ");            
        }
    }