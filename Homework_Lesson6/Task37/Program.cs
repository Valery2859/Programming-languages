﻿// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        Random myRandom = new Random();
        int size2 = 0;
        int a = size - 1;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = myRandom.Next(0, 10 + size);
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine(" ");
        size2 = size / 2;
        if (size%2 !=0) size2 += 1;
        int b = 0;
        int[] array2 = new int[size2];
        for (int i = 0; i < size2; i++)
        {
            b = a - i;
            if (i != b)
                array2[i] = array[i] * array[b];
            else
                array2[i] = array[i];
            Console.Write("{0} ", array2[i]);
        }
        Console.WriteLine(" ");






        // Console.Write(" --> {0} чётных", result);
        //  Console.WriteLine(" ");
    }
}