// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
 
Console.Clear(); 
Console.WriteLine("Задайте b1: "); 
double b1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Задайте к1: "); 
double k1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Задайте b2: "); 
double b2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Задайте k2: "); 
double k2 = Convert.ToInt32(Console.ReadLine()); 
 
void Point (double b11, double k11, double b12, double k12 ) 
{ 
double x1 = k11 - k12; 
double x2 = b12 - b11; 
double x = x2/x1; 
double y = k11*x+b11; 
Console.WriteLine($"b1 = {b11}, k1 = {k11}, b2 = {b12}, k2 = {k12} -> ({x}; {y})"); 
} 
Point (b1,k1,b2,k2);