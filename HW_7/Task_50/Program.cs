// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


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
            matrix[i, j] = rand.Next(10, 100);
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
            System.Console.Write(matr[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

// int[] ArrayForSavePosition(string text) // Решение №2 через создания отдельного массива для записи индексов искомой позиции через строку.
// {
//     System.Console.Write(text);
//     return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// }

// void FindPosition(int[,] matr, int[] arr) // Решение №2 через создания отдельного массива для записи индексов искомой позиции через строку.
// {
//     if (arr[0] < matr.GetLength(0) && arr[1] < matr.GetLength(1))
//     {
//         System.Console.Write($"The desired position in the matrix: {matr[arr[0], arr[1]]}");

//     }
//     else
//     {
//         System.Console.WriteLine("This position is not in the matrix");
//     }
// }

void FindPosition(int[,] matr, int row, int col) // Решение №1 через ввдение отдельных индексов для строки и столбца.
{
    if (row < matr.GetLength(0) && col < matr.GetLength(1))
    {
        System.Console.Write($"The desired position in the matrix: {matr[row, col]}");

    }
    else
    {
        System.Console.WriteLine("This position is not in the matrix");
    }
}

int m = ReadInt("Enter the number of matrix rows: ");
int n = ReadInt("Enter the number of matrix columns: ");
var myMatrix = GenereteMatrix(m, n);
PrintMatrix(myMatrix);

// int[] searchArray = ArrayForSavePosition("Enter 2 numbers - the row and column index of the position you are looking for: "); // Решение №2 через создания отдельного массива для записи индексов искомой позиции через строку.

int rowIndex = ReadInt("Enter the row index of the position you are looking for:  "); // Решение №1 через ввдение отдельных индексов для строки и столбца.
int colIndex = ReadInt("Enter the column index of the position you are looking for:  ");

FindPosition(myMatrix, rowIndex, colIndex);
// FindPosition(myMatrix, searchArray); // Решение №2 через создания отдельного массива для записи индексов искомой позиции через строку.