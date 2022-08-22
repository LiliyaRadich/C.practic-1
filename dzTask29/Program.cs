// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] 
 
Console.Clear(); 
int[] array = new int[8]; 
 
int[] CreateMas(int[] n) 
{ 
    Console.Write("["); 
    for (int i = 0; i < n.Length; i++) 
    { 
        n[i] = new Random().Next(0, 100); 
        if (i != n.Length -1) Console.Write(n[i] + ", "); 
        else Console.Write(n[i]); 
    } 
    Console.Write("]"); 
    return n; 
} 
CreateMas(array);
