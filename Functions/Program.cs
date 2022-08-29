/*


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]}");
}
Console.WriteLine();
}
void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;
    for (int j = i+1; j < array.Length; j++)
        {
           if(array[j] < array[minPosition]) minPosition = j;
           {
               minPosition = j;
           }
        }
int temporary = array[i];
array[i] = array[minPosition];
array[minPosition] = temporary;
}
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/

void DO() //Функция ничегоне принимает и ничего не отдает
{

}
void DO2(int number) // Функция принимает число и ничего не отдает
{

}
int DO3()// Функция ничего не принимает и отдает число
{
    return 1;
}
int DO4(int number) // Функция принимает и отдает число
{
    return number;
}
string DO5(int number) //Функция принимает число и отдает строку
{
    return number.ToString()+ " яблок";
}
string str = DO5(5);
Console.WriteLine(str);
