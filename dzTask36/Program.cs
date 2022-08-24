// Задайте одномерный массив, заполненный случайными числами.  
// Найдите сумму элементов, стоящих на нечётных позициях (индексах). 
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0 
 
Console.Clear(); 
int[] create = CreateArray(5); 
Print(create); 
Console.Write(" -> "); 
int chet = NeChet(create); 
Console.WriteLine(chet); 
 
int[] CreateArray(int size) // Название метода 
{ 
    if (size == 0) 
        return new int[] { }; // проверка что массив не = 0 
 
    int[] array = new int[size]; // создание массива 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++) 
    { 
        array[i] = rnd.Next(-100, 99 + 1); 
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
 
int NeChet(int[] array) 
{ 
    int summ = 0; 
    for (int i = 1; i < array.Length; i = i+2) 
    { 
        summ = summ + array[i]; 
    } 
    return summ; 
}
