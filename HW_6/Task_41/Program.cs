// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputArray(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("Array: " + "[" + string.Join(", ", arr) + "]");
}

int CountNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.WriteLine();
int[] myArray = InputArray("Enter some numbers: ");
System.Console.WriteLine();
PrintArray(myArray);
System.Console.WriteLine($"Amount of numbers greater than 0 entered by the user: {CountNumbers(myArray)}");
System.Console.WriteLine();