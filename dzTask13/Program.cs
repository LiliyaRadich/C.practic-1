// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6 

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num / 100;
int num1 = num;
int count = 0;
if (a == 0) Console.WriteLine("Третьей цифры нет");
else
    while (num1 > 0)
    {
        num1 = num1 / 10;
        count++;
    }
while (count != 3)
{
    num = num / 10;
    count--;
}
num = num % 100;
num = num % 10;
Console.WriteLine($"Третья цифра -> {num}");