﻿// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenereteMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(-10, 10)+ Math.Round(rand.NextDouble(), 1);
        }
    }
    return matrix;

}

void PrintMatrix(double[,] matr)
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

int m = ReadInt("Enter the number of matrix rows: ");
int n = ReadInt("Enter the number of matrix columns: ");
var myMatrix = GenereteMatrix(m, n);
PrintMatrix(myMatrix);