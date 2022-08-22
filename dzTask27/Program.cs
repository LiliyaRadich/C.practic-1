//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// 452 -> 11 
// 82 -> 10 
// 9012 -> 12 
Console.Clear(); 
Console.Write("Введите целое положительное число: "); 
int dig = Convert.ToInt32(Console.ReadLine()); 
void Summ(int a) 
{ 
    int b = 0; 
    int a1 =a; 
    int count = 0; 
    { 
        while (a > 0) 
        { 
            a = a / 10; 
            count++; 
        } 
        while (count > 0) 
        { 
            b = b + a1 % 10; 
            a1 = a1 / 10; 
            count--; 
        } 
    } 
    Console.Write(b); 
} 
Summ(dig);