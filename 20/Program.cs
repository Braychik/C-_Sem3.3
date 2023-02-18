// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.Clear();
Console.Write("Введите координаты Х первой точки: ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y первой точки: ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Х второй точки: ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y второй точки: ");
double Y2 = double.Parse(Console.ReadLine());
//double sqrt = ((X1 - Y1)^2 + (Y1 - Y2)^2);
double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));//Math.Sqrt - под корень Math.Pow - в квадрат
Console.WriteLine($"Расстояние между точками {result} ");
/*
Решение кирилла


Console.Clear();
Console.Write("Введите X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = double.Parse(Console.ReadLine());
double d1 = Math.Sqrt(-5);

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));//(x1 - x2)* (x1 - x2 )

Console.WriteLine($"d={d:f3}, {d1}");*/