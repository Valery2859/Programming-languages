

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число ");
        ReadNumber(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Введите ещё одно число ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MultipleTwoNumber(PowTwoNumber(number)));

        Console.ReadLine();


    }
}