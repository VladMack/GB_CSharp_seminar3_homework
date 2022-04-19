using System;

Console.Clear();
Console.WriteLine("Введи число:");
string numS = Console.ReadLine();
string result = $"Число {numS} является палиндромом.";

for (int i = 0; i <= numS.Length / 2; i++)
{
    if (numS[i].ToString() != numS[numS.Length - 1 - i].ToString())
    {
        result = $"Число {numS} не является палиндромом.";
    }
}
Console.WriteLine(result);