﻿// //  Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N. 
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = -num;
while (num1 <= num)
{
    Console.Write($"{num1}, ");
    num1++;
}