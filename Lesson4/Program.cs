

class Program
{
static int PowTwoNumber(int number)
{
    return number * number;
}
static string MultipleTwoNumber(int number)
{
    return number % 2 == 0 ? "Кратное" : "Не кратное";
}
static void ReadNumber(int number)
{
    Console.WriteLine(number * number);
}
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