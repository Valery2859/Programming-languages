// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
/*
 Console.WriteLine("Введите через запятую целые числа и нажмите Enter");
            string[] nums = Console.ReadLine().Split(new char[] { ',' });
            int[] intArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                intArray[i] = int.Parse(nums[i]);
            }
            Console.WriteLine("Неотсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }*/
class Program
    {
        public static int[,] mult(int[,] ar1, int[,] ar2)
        {
            int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];
 
            for (int i = 0; i < ar1.GetLength(0); ++i)
                for (int j = 0; j < ar2.GetLength(0); ++j)
                    for (int k = 0; k < ar2.GetLength(1); ++k)
                        m[i, k] += ar1[i, j] * ar2[j, k];
            return m;
        }
 
        static void Test1()
        {
            int[,] ar1 = { { 2, 4}, { 3,2 } };
            int[,] ar2 = { { 3, 4}, {3, 3 } };
 
            int[,] m = mult(ar1, ar2);
 
            for (int i = 0; i < ar1.GetLength(0); ++i)
            {
                for (int j = 0; j < ar2.GetLength(1); ++j)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
 
        static void Main()
        {
            Test1();
        }
    }