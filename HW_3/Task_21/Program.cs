// Задача 21
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int[] coordsA = new int[3];

System.Console.WriteLine("Input the X coordinate of point A: ");

coordsA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input the Y coordinate of point A:  ");

coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input the Z coordinate of point A:  ");

coordsA[2] = Convert.ToInt32(Console.ReadLine());

int[] coordsB = new int[3];

System.Console.WriteLine("Input the X coordinate of point B: ");

coordsB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input the Y coordinate of point B:  ");

coordsB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input the Z coordinate of point B:  ");

coordsB[2] = Convert.ToInt32(Console.ReadLine());

int distanceX = (int)Math.Pow(coordsB[0] - coordsA[0], 2);
int distanceY = (int)Math.Pow(coordsB[1] - coordsA[1], 2);
int distanceZ = (int)Math.Pow(coordsB[2] - coordsA[2], 2);

double result = Math.Sqrt(distanceX + distanceY + distanceZ);

System.Console.WriteLine(Math.Round(result, 2));