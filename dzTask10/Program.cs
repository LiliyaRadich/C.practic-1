// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе  
// показывает вторую цифру этого числа. 

// 456 -> 5 
// 782 -> 8 
// 918 -> 1 

Console.Write("Введите трехзначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = num / 10;
int digit1 = digit % 10;
Console.WriteLine($"Вторая цифрой из числа {num} -> {digit1} ");