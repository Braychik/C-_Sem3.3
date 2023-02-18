// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);
Console.Clear();
Console.Write("Введите координаты Х первой точки: ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y первой точки: ");
int Y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Х второй точки: ");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y второй точки: ");
int Y2 = int.Parse(Console.ReadLine());
//double sqrt = ((X1 - Y1)^2 + (Y1 - Y2)^2);
double result = Math.Sqrt(((X1 - X1)^2 + (Y1 - Y2)^2));
Console.WriteLine($"Расстояние между точками {result} ");
