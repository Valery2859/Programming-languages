

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
public static void Main(string[] args)
{
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(MultipleTwoNumber(PowTwoNumber(number)));

    Console.ReadLine();

}
}