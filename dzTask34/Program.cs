// Задайте массив заполненный случайными положительными трёхзначными числами.  
// Напишите программу, которая покажет количество чётных чисел в массиве. 
// [345, 897, 568, 234] -> 2 
 
Console.Clear (); 
int[] create = CreateArray(6); 
Print(create); 
Console.Write(" -> "); 
int chet = ChetneChet(create); 
Console.WriteLine(chet); 
 
int ChetneChet(int[] array) 
{ 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] % 2 == 0) count++; 
    } 
    return count; 
} 
 
int[] CreateArray(int size) // Название метода 
{ 
    if (size == 0) 
        return new int[] { }; // проверка что массив не = 0 
 
    int[] array = new int[size]; // создание массива 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++) 
    { 
        array[i] = rnd.Next(100, 999 + 1); 
    } 
    return array; 
} 
 
void Print(int[] array) 
{ 
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (i < array.Length - 1) Console.Write(array[i] + ", "); 
        else Console.Write(array[i]); 
    } 
    Console.Write("]");
}