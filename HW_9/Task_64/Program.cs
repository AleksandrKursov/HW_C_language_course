// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int num)
{
    if (num == 0) return;
    System.Console.Write(num + " ");
    WriteNumbers(num - 1);
}

System.Console.WriteLine();
int n = ReadInt("Enter the number N: ");
System.Console.Write($"Numbers from {n} to 1: ");
WriteNumbers(n);