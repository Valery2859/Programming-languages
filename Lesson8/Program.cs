// Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

/*
class Program
{
    
    static void Main()
    {
        Console.WriteLine("Введите сторону а: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сторону b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сторону c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Треугольник существует");
        }
        else
        {
            Console.WriteLine("Треугольник не существует");
        }
    }*/
//НАПИСАТЬ ПРОГРАММУ КОТОРАЯ ВВОДИТ МАССИВ ИЗ N ЭЛЕМЕНТОВ, ЗАПОЛНЕННЫЙ НУЛЯМИ
// И ЕДИНИЦАМИ В СЛУЧАЙНОМ ПОРЯДКЕ
int ReadStringConvertInt(string word)
{
    return int.Parse(word);
}
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}
void GetConsoleArray(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}
int number = ReadStringConvertInt(Console.ReadLine());
int[] array = GetBinaryArray(number);
GetConsoleArray(array);