// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
 
Console.Clear(); 
int[,] create = CreateArray(4, 4); 
Print(create); 
double [] rezult = MiddleElem(create); 
Print1(rezult); 
 
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
void Print1(double[] array) 
{ 
    Console.Write("Среднее арифметическое каждого столбца матрицы: [ "); 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (i < array.Length - 1) Console.Write(array[i] + "; "); 
        else Console.Write(array[i]); 
    } 
    Console.Write(" ]"); 
} 
double[] MiddleElem(int[,] array) 
{ 
    double sum = 0; 
    double num = 0; 
    int k = 0; 
    int sizerow = array.GetLength(0); 
    int sizecol = array.GetLength(1); 
    double[] resarray = new double[sizecol]; 
    for (int i = 0; i < sizerow; i++) 
    { 
        for (int j = 0; j < sizecol; j++) 
            sum += array[j, i]; 
        num = sum / sizerow; 
        resarray[k] = num; 
        sum = 0; 
        k++; 
    } 
    return resarray; 
}