﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
int result = number%2;
if(result == 1)
{
    Console.Write("нет, число нечётное");
}
if(result == 0)
{
    Console.Write("да, число является чётным");
}
