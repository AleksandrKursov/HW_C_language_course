// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Input five-digit number: ");
string? str = Console.ReadLine();
if (str!.Length == 5)
{
    if(str[0] == str[4] && str[1] ==str[3])
    {
        System.Console.WriteLine("Yes, it is a polyndrom number");
    }
    else{
        System.Console.WriteLine("This number is not a polydrome");
    } 
}
else
{
    System.Console.WriteLine("Number is not five-digit");
}