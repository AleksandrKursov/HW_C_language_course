// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiation(int A, int B)
{
    if (B > 0)
    {
        int result = 1;
        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }
        return result;
    }
    else
    {
        return 1;
    }

}

int number = ReadInt("Введите число А: ");
int number2 = ReadInt("Введите число B: ");
System.Console.WriteLine($"Число {number} в степени {number2} = {Exponentiation(number, number2)}");