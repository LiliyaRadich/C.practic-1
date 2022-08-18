// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// A (3,6,8); B (2,1,-7), -> 15.84 
// A (7,-5, 0); B (1,-1,9) -> 11.53 
 
Console.Clear(); 
Console.WriteLine("Введите координаты точки: "); 
Console.Write("X1: "); 
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Y1: "); 
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Z1: "); 
int z1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("X2: "); 
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Y2: "); 
int y2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Z2: "); 
int z2 = Convert.ToInt32(Console.ReadLine()); 
 
double Summlenght(int x1c, int y1c, int z1c, int x2c, int y2c, int z2c) 
{ 
    return Math.Sqrt((x2c - x1c) * (x2c - x1c) + (y2c - y1c) * (y2 - y1) + (z2c - z1c) * (z2c - z1c)); 
} 
double result = Summlenght(x1, y1, z1, x2, y2, z2); 
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));