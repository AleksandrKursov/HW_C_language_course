// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number > 999)
    {
        number /= 10;
    }
    int third_digit = number % 10;
    System.Console.WriteLine($"Third digit of the number: {third_digit}");
}
else
{
    System.Console.WriteLine($"No third number");
}