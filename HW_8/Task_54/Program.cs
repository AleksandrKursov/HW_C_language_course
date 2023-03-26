// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            matrix[i, j] = rand.Next(-9, 10);
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

void MatrixRowOrdering(int[,] matr)
{
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (-matr[i, k] > -matr[i, k + 1])
                {
                    temp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = temp;
                }
            }
        }
    }
}

System.Console.WriteLine();
int m = ReadInt("Enter the number of matrix rows: ");
int n = ReadInt("Enter the number of matrix columns: ");
int[,] myMatrix = GenereteMatrix(m, n);
System.Console.WriteLine();
System.Console.WriteLine("Source Matrix: ");
PrintMatrix(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Matrix with ordered elements in rows in descending order");
MatrixRowOrdering(myMatrix);
PrintMatrix(myMatrix);
System.Console.WriteLine();