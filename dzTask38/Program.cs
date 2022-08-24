// Задайте массив вещественных чисел.  
// Найдите разницу между максимальным и минимальным элементами массива. 
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 
 
Console.Clear(); 
double[] create = CreateArray(10, 0, 100); 
Print(create); 
Console.Write(" -> "); 
double rez = MinMax(create); 
Console.WriteLine(Math.Round(rez,1,MidpointRounding.ToZero)); 
 
double[] CreateArray(int size, int min, int max) // Название метода 
{ 
    if (size == 0) 
        return new double[] {} ; // проверка что массив не = 0 
 
    double[] array = new double[size]; // создание массива 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++) 
    { 
        array[i] = rnd.NextDouble() * (max - min) + min; 
    } 
    return array; 
} 
 
void Print(double[] array) 
{ 
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (i < array.Length - 1) Console.Write(Math.Round(array[i], 1, MidpointRounding.ToZero) + ", "); 
        else Console.Write(Math.Round(array[i], 1, MidpointRounding.ToZero)); 
    } 
    Console.Write("]"); 
} 
double MinMax(double[] array) 
{ 
    double min = array[0]; 
    double max = array[0]; 
        for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] < min) min = array[i]; 
        if (array[i] > max) max = array[i]; 
    } 
    double rezult = max-min; 
    return rezult; 
}