// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру
// этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (99 < number && number < 1000)
{
    int right_number = number % 100;
    int second_number = right_number / 10;
    System.Console.WriteLine($"Second digit of the number: {second_number}");
}
else
{
    System.Console.WriteLine("Non-three-digit number entered");
}