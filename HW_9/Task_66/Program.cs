// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbersFromMToN(int m, int n)
{
    if (m == n + 1) return 0;
    return m + SumNumbersFromMToN(m + 1, n);
}

System.Console.WriteLine();
int m = ReadInt("Enter the number M: ");
int n = ReadInt("Enter the number N: ");
if (m < n)
{
    System.Console.Write($"Sum of numbers from {m} to {n}: ");
    System.Console.WriteLine(SumNumbersFromMToN(m, n));
    System.Console.WriteLine();
}
else
{
    System.Console.Write($"Sum of numbers from {n} to {m}: ");
    System.Console.WriteLine(SumNumbersFromMToN(n, m));
    System.Console.WriteLine();
}
