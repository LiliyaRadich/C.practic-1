// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 2;
while (num1 <= num)
{
    Console.Write($"{num1}, ");
   num1 = num1+2;
}