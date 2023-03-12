// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigit(int number)
{
    int i = 0;
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
        i++;
    }
    return sum;
}
int Modulo(int number)
{
    if (number < 0)
    {
        number = -number;
    }
    return number;
}

int number = ReadInt("Input a number: ");
System.Console.WriteLine($"Sum of the digits in a number {number} = {SumDigit(Modulo(number))}");