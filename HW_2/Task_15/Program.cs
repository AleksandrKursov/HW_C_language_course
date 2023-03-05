// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Input the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    System.Console.WriteLine("No");
}
else if(number == 2)
{
    System.Console.WriteLine("No");
}
else if(number == 3)
{
    System.Console.WriteLine("No");
}
else if(number == 4)
{
    System.Console.WriteLine("No");
}
else if(number == 5)
{
    System.Console.WriteLine("No");
}
else if(number == 6)
{
    System.Console.WriteLine("Yes");
}
else if(number == 7)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("There is no such day of the week");
}