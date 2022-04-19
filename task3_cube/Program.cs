using System;

Console.Clear();
Console.Write("Введи число:");
int num = int.Parse(Console.ReadLine());
string result = "";
for (int i = 1; i <= num; i++)
{
    result += $"{Math.Pow(i, 3).ToString()} ";
}
Console.WriteLine($"КУбы чистел от 1 до {num}: {result}");