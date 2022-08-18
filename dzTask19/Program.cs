// // Напишите программу, которая принимает  
// 1.на вход пятизначное число  
// 2.и проверяет, является ли оно палиндромом. 
// // 14212 -> нет 
// // 12821 -> да 
// // 23432 -> да 

Console.Clear();
Console.Write("Введите пятизначное целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num / 10000;
int num1 = 0;
int num2 = 0;
int num4 = 0;
int num5 = 0;
if (a == 0 || a > 10) Console.WriteLine("Число не пятизначное");
else
{
    num1 = num / 10000;
    num2 = num / 1000 % 10;
    num4 = num % 100 / 10;
    num5 = num % 10;
    if (num1 == num5 && num2 == num4) Console.WriteLine("Число полиандром");
    else Console.WriteLine("Число не полиандром");
}