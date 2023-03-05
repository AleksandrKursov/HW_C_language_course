// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа
//  от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i += 2) // Упрощенное решение
{
    System.Console.Write(i + " ");
    // if (i % 2 == 0) - // Первый вариант решения, в цикле for "i = 1", а счетчик "i++"
    // {
    //     System.Console.Write(i + " ");
    // }
}