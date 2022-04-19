using System;

Console.Clear();
Console.Write("Введите координату X, Y и Z начала отрезка через пробел:");
string[] x1y1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int x1 = int.Parse(x1y1[0]);
int y1 = int.Parse(x1y1[1]);
int z1 = int.Parse(x1y1[2]);
Console.Write("Введите координату X, Y и Z конца отрезка через пробел:");
string[] x2y2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int x2 = int.Parse(x2y2[0]);
int y2 = int.Parse(x2y2[1]);
int z2 = int.Parse(x2y2[2]);

double length = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));

Console.Write($"Длина отрезка: {length:f2}.");