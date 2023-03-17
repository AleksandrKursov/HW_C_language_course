// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов (размер массива задается числом введенным пользователем) и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] - возможно, тут имелось ввиду ввод каждого числа с клавиатуры, но реализовано через генервцию.
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string text)
{
    System.Console.Write(text);
    // string readInput = System.Console.ReadLine(); // Более длинный, но пошаговый способ, сначала сохраняем введенную строку.
    // int result = int.Parse(readInput); // в этой строке конвертируем строку в число.
    // return result; // возвращаем число.
    return Convert.ToInt32(Console.ReadLine());
    
}

int[] GenArray(int size) // Если не поставить после int "[]", то не получится вернуть массив в конце.
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int size = ReadInt("Enter a size of array: ");
int[] myArray = GenArray(size); // взамен int[] можно поставить var - сам определит.
PrintArray(myArray);