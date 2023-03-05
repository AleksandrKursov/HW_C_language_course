// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Input number_1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number_2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number_3: ");
int number_3 = Convert.ToInt32(Console.ReadLine());
if (number_1 > number_2 && number_1 > number_3)
{
    System.Console.WriteLine($"number_1 = {number_1} is max");
    
}
else if (number_2 > number_1 && number_2 > number_3)
{
    System.Console.WriteLine($"number_2 = {number_2} is max");
}
else
{
    System.Console.WriteLine($"number_3 = {number_3} is max");
}