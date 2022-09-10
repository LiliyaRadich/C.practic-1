﻿// Задача 64: Задайте значение N. Напишите программу,  
// которая выведет все натуральные числа в промежутке от N до 1.  
// Выполнить с помощью рекурсии. 
// N = 5 -> "5, 4, 3, 2, 1" 
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
 
Console.Clear(); 
Console.Write("Введите целое число N больше нуля: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
if (num <= 0) return; 
Console.Write($"N = {num} -> "); 
Nature(num); 
void Nature(int num1)
{ 
    Console.Write($"{num1} "); 
    if (num1 == 1) return; 
    Nature(num1 - 1); 
}