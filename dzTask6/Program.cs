﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите целое число: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
int rez = num % 2;
if (rez==0)
{
    Console.Write("четное");
}
else
{
    Console.Write("нечетное");
}