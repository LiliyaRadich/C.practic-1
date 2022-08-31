// // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// m = 3, n = 4. 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9 
// 8 7,8 -7,1 9 
 
Console.Clear(); 
Console.WriteLine("Введите количество строк Массива: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов Массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
 
double[,] create = CreateArray(m, n, 0, 10); 
Print(create); 
 
double[,] CreateArray(int m1, int n1, int min, int max) 
{ 
    double[,] array = new double[m1, n1]; 
    Random rnd = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            array[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero); 
    } 
    return array; 
} 
void Print(double[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        Console.Write("["); 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],4},"); 
            else Console.Write($"{array[i, j],4} "); 
        } 
        Console.WriteLine("]"); 
    } 
}