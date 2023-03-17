// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("Array: " + "[" + string.Join(", ", arr) + "]");
}

int SumNumbersOddIndices(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
System.Console.WriteLine();
int size = ReadInt("Enter a size of array: ");
System.Console.WriteLine();
const int LEFT_RANGE = -99;
const int RIGHT_RANGE = 99;
int[] array = GenArray(size, LEFT_RANGE, RIGHT_RANGE);
PrintArray(array);
System.Console.WriteLine("Sum of numbers on a odd positions: " + SumNumbersOddIndices(array));
System.Console.WriteLine();
