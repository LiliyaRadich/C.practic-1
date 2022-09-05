// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,  
// которая будет находить строку с наименьшей суммой элементов. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
 
 
Console.Clear(); 
int[,] res = CreateArray(4, 4); 
Print(res); 
Console.WriteLine(); 
int[] result = Rowsumm(res); 
Print1(result); 
Minrow (result); 
 
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
void Print1(int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
        Console.WriteLine(array[i]); 
} 
int[] Rowsumm(int[,] array) 
{ 
    int sum = 0; 
    int k = 0; 
    int sizerow = array.GetLength(0); 
    int sizecol = array.GetLength(1); 
    int[] resarray = new int[sizerow]; 
    for (int i = 0; i < sizecol; i++) 
    { 
        for (int j = 0; j < sizerow; j++) 
            sum += array[i, j]; 
        resarray[k] = sum; 
        k++; 
        sum = 0; 
    } 
    return resarray; 
} 
void Minrow(int[] array) 
{ 
    int min = array[0]; 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] < min) 
        { 
            min = array[i]; 
        count = i; 
        } 
    } 
    Console.Write($"Минимальная сумма элементов в строке -> {count+1}"); 
}