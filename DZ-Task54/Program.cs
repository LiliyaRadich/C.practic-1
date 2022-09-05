// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// В итоге получается вот такой массив: 
// 7 4 2 1 
// 9 5 3 2 
// 8 4 4 2 
 
Console.Clear(); 
Console.WriteLine("Введите количество строк Массива: "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов Массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
 
int[,] res = CreateArray(m, n); 
Print(res); 
Console.WriteLine(); 
int[,] sort1 = Sortarray1(res); 
Print(sort1); 
 
int[,] CreateArray(int m1, int n1) 
{ 
    int[,] array = new int[m1, n1]; 
    Random rnd = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            array[i, j] = rnd.Next(0, 10 + 1); 
    } 
    return array; 
} 
void Print(int[,] array) 
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
int[,] Sortarray1(int[,] mas) 
{ 
    for (int i = 0; i < mas.GetLength(1); i++) 
    { 
        for (int j = 0; j < mas.GetLength(0); j++) 
        { 
            for (int q = i + 1; q < mas.GetLength(1); q++) 
            { 
                if (mas[j, i] < mas[j, q]) 
                { 
                    int temp = mas[j, i]; 
                    mas[j, i] = mas[j, q]; 
                    mas[j, q] = temp; 
                } 
            } 
        } 
    } 
    return mas; 
} 
 