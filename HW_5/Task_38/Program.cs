// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenArray(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1) + Math.Round(rand.NextDouble(), 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("Array: " + "[" + string.Join(", ", arr) + "]");
}

double DifferenceMaxAndMin(double[] arr)
{
    double diff = 0;
    double maxNum = arr[0];
    double minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNum)
        {
            maxNum = arr[i];
        }
        else if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
        diff = maxNum - minNum; // Вроде как правильно и для отрицательных чисел по модулю брать не нужно. 
    return Math.Round(diff, 2);
}

System.Console.WriteLine();
int size = ReadInt("Enter a size of array: ");
System.Console.WriteLine();
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
double[] array = GenArray(size, LEFT_RANGE, RIGHT_RANGE);
PrintArray(array);
System.Console.WriteLine($"Difference between the maximum number in the array and the minimum: {DifferenceMaxAndMin(array)}");
System.Console.WriteLine();