// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckForNegativeNumbers(int m, int n)
{
    if (m < 0 || n < 0)
    {
        System.Console.WriteLine("Entered negative numbers!");
        return false;
    }
    else return true;
}

int FunctionAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    // else if (m > 0 && n == 0) return FunctionAckerman(m - 1, 1); Необязательно задавать условие m > 0, так как ранее m и n проверены на отрицательные значения.
    else if (n == 0) return FunctionAckerman(m - 1, 1);
    else return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}

System.Console.WriteLine();
int m = ReadInt("Enter the number m: ");
int n = ReadInt("Enter the number n: ");
if (CheckForNegativeNumbers(m, n) == true)
{
    System.Console.Write($"Сalculated number by Ackermann function A(m, n) = ");
    System.Console.WriteLine(FunctionAckerman(m, n));
    System.Console.WriteLine();
}
