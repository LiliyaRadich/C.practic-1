// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 1, 7 -> такого элемента в массиве нет 
 
Console.Clear(); 
int[,] create = CreateArray(5, 5); 
Print(create); 
Console.WriteLine("Введите номер строки элемента в Массиве:"); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите номер столбца элемента в Массиве:"); 
int n = Convert.ToInt32(Console.ReadLine()); 
if (m<=0 || n<=0)  
{ 
    Console.WriteLine("не корректные значения для поиска"); 
return ; 
} 
FindElement(create, m, n); 
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
void FindElement (int [,] array, int row, int col) 
{ 
    if (row > array.GetLength(0) || col > array.GetLength(1))  
    Console.Write($"{row}, {col} - > элемента с таким номером в массиве нет"); 
    else  Console.Write($"Ваш элемент -> {array[row-1,col-1]}"); 
}