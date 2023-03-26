// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

bool CheckPossibilityMultiplication(int m, int n, int k, int l)
{
        if (n == k)
    {
        System.Console.WriteLine($"Matrices {m}-by-{n} and {k}-by-{l} can be multiplied");
        return true;
    }
    else
    {
        return false;
    }
}

void MultiplicationMatrices(int[,] firstMatrix, int[,] secondMatrix, bool canOrCannot)
{
    if (canOrCannot == true)
    {
        int[,] newMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    newMatrix[i, j] = newMatrix[i, j] + firstMatrix[i, k] * secondMatrix[k, j];
                }
                System.Console.Write(newMatrix[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }
    else
    {
        System.Console.WriteLine("Matrices cannot be multiplied!");
    }
}

System.Console.WriteLine();
int m = ReadInt("Enter the number of rows in the first matrix: ");
int n = ReadInt("Enter the number of columns in the first matrix: ");
int[,] firstMatrix = GenereteMatrix(m, n);
int k = ReadInt("Enter the number of rows in the second matrix: ");
int l = ReadInt("Enter the number of columns in the second matrix: ");
int[,] secondMatrix = GenereteMatrix(k, l);
System.Console.WriteLine();
System.Console.WriteLine("First matrix: ");
PrintMatrix(firstMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Second matrix: ");
PrintMatrix(secondMatrix);
System.Console.WriteLine();

bool canOrCannot = CheckPossibilityMultiplication(m, n, k, l);
System.Console.WriteLine();
System.Console.WriteLine("New matrix: ");
MultiplicationMatrices(firstMatrix, secondMatrix, canOrCannot);
System.Console.WriteLine();