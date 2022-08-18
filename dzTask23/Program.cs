// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125 
 
Console.Write("Введите целое число : "); 
int n = Convert.ToInt32(Console.ReadLine()); 
if (n < 1) Console.WriteLine("введите число больше 1"); 
 
void PrintQuard(int a) 
{ 
    for (int i = 1; i < a+1; i++) 
        Console.WriteLine($"{i} \t {i * i * i}"); 
} 
PrintQuard(n);