// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵) 
// 2, 4 -> 16 
 
Console.Clear(); 
Console.Write("Введите 2 целых чиcла: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
 
void Step(int did1, int did2) 
{ 
    int count = 0; 
    int did11 = did1; 
    int did22 = did2; 
    { 
        while (did2 > 1) 
        { 
            did2 = did2 - 1; 
            count++; 
        } 
        while (count > 0) 
        { 
            did1 = did1 * did11; 
            count--; 
        } 
    } 
    Console.Write($"Число {did11} в степени {did22} = {did1}"); 
} 
Step(a, b);
