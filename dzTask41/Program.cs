// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// 0, 7, 8, -2, -2 -> 2 
// 1, -7, 567, 89, 223-> 3 
 
Console.Clear(); 
Console.WriteLine("Задайте количество чисел для ввода: "); 
int qty = Convert.ToInt32(Console.ReadLine()); 
if (qty <= 0) 
{ 
    Console.WriteLine("Количество чисел для ввода, должно быть больше нуля"); 
    return; 
} 
int[] Create(int size) 
{ 
    int[] arr = new int[size]; 
    int j = 1; 
    for (int i = 0; i < size; i++) 
    { 
        Console.WriteLine($"Введите число {j}: "); 
        arr[i] = Convert.ToInt32(Console.ReadLine()); 
        j++;
    } 
    return arr; 
} 
void Print(int[] array) 
{ 
 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (i < array.Length - 1) Console.Write(array[i] + ", "); 
        else Console.Write(array[i]); 
    } 
} 
void Pos(int[] array) 
{ 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
        if (array[i] > 0) count++; 
    Console.WriteLine(count); 
} 
int[] result = Create(qty); 
Print(result); 
Console.Write(" -> "); 
Pos(result);