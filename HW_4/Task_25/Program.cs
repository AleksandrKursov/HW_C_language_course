// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidatePower(int B)
{
    if (B < 0)
    {
        System.Console.WriteLine("Степень не должна быть меньше нуля");
        return false;
    }
    return true;
}

int Exponentiation(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

int number = ReadInt("Введите число А: ");
int power = ReadInt("Введите число B: ");
if (ValidatePower(power))
{
    System.Console.WriteLine($"Число {number} в степени {power} = {Exponentiation(number, power)}");
}
