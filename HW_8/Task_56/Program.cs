// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenereteMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;

}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] SumOfNumbersInRows(int[,] matr)
{
    int[] arraySumOfNumbersInRows = new int[matr.GetLength(0)];
    for (int i = 0; i < arraySumOfNumbersInRows.Length; i++)
    {
        int sumOfNumbersInRow = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumOfNumbersInRow += matr[i, j];
        }
        arraySumOfNumbersInRows[i] = sumOfNumbersInRow;
    }
    return arraySumOfNumbersInRows;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"The sum of the numbers in the row {i + 1} is: {arr[i]}");
    }

}

int MinimumSumOfNumbers(int[] array)
{
    int rowWithMinSum = array[0];
    int indexRowWithMinSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < rowWithMinSum)
        {
            rowWithMinSum = array[i];
            indexRowWithMinSum = i + 1;
        }
    }
    return indexRowWithMinSum;
}

System.Console.WriteLine();
int m = ReadInt("Enter the number of matrix rows: ");
int n = ReadInt("Enter the number of matrix columns: ");
int[,] myMatrix = GenereteMatrix(m, n);
System.Console.WriteLine();
System.Console.WriteLine("Matrix: ");
PrintMatrix(myMatrix);
System.Console.WriteLine();
int[] myArray = SumOfNumbersInRows(myMatrix);
PrintArray(myArray);
System.Console.WriteLine();
System.Console.WriteLine($"The row with the smallest sum of elements: {MinimumSumOfNumbers(myArray)} row");
System.Console.WriteLine();