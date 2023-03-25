// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            matrix[i, j] = rand.Next(-10, 11);
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

double[] AverageOfNumbersInColumns(int[,] matr)
{
    double[] averageNumberInColumns = new double[matr.GetLength(1)];
    for (int i = 0; i < averageNumberInColumns.Length; i++)
    {
        double sumOfNumbersInColumn = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            sumOfNumbersInColumn = sumOfNumbersInColumn + matr[j, i];
        }
        averageNumberInColumns[i] = sumOfNumbersInColumn / matr.GetLength(0);
        averageNumberInColumns[i] = Math.Round(averageNumberInColumns[i], 2);

    }
    return averageNumberInColumns;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine(string.Join(";\t", arr));
}


int m = ReadInt("Enter the number of matrix rows: ");
int n = ReadInt("Enter the number of matrix columns: ");
int[,] myMatrix = GenereteMatrix(m, n);
System.Console.WriteLine();
PrintMatrix(myMatrix);
var arrayAverageOfNumbersInColumns = AverageOfNumbersInColumns(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Arithmetic mean of all numbers in each column: ");
PrintArray(arrayAverageOfNumbersInColumns);
System.Console.WriteLine();