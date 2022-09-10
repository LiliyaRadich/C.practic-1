// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// M = 1; N = 15 -> 120 
// M = 4; N = 8. -> 30 
Console.Clear();
Console.Write("Введите 2 целых положительных чиcла(второе число, должно быть больше первого): ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a < 0 || b <= 0 || b <= a) return;
int sum = Stepen(a, b);
Console.Write($"Cуммa натуральных элементов в промежутке от {a} до {b} -> {sum}");
int Stepen(int dig1, int dig2)
{
    if (dig1 == dig2) return dig1;
    return dig1 + Stepen(dig1 + 1, dig2); ;
}