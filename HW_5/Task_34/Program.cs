// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    var rand = new Random(); // var можно использовать взамен Random.
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

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {        
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int size = ReadInt("Enter a size of array: ");
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;
int[] array = GenArray(size, LEFT_RANGE, RIGHT_RANGE);
PrintArray(array);
System.Console.WriteLine("The amount of even numbers in the array: " + CountEvenNumbers(array));
