//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
// Например, даны 2 матрицы: 
// 2 4 | 3 4 
// 3 2 | 3 3 
// Результирующая матрица будет: 
// 18 20 
// 15 18 
 
Console.Clear(); 
int[,] matrix1 = CreateArray(2, 2); 
Print(matrix1); 
Console.WriteLine(); 
int[,] matrix2 = CreateArray(2, 2); 
Print(matrix2); 
Console.WriteLine( "Произведение матриц:"); 
int[,] mainmatrix = Mainmatrix(matrix1, matrix2); 
Print(mainmatrix); 
 
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
int[,] Mainmatrix (int[,] matrix1, int[,] matrix2) 
{ 
    int row = matrix1.GetLength(0); 
    int col = matrix1.GetLength(1); 
    int[,] mainMatrix = new int[row, col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            for (int q = 0; q < row; q++) 
            { 
                mainMatrix[i, j] += matrix1[i, q] * matrix2[q, j]; 
            } 
        } 
    } 
    return mainMatrix; 
}