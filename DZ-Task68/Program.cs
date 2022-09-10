// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29 
 
Console.Clear(); 
Console.Write("Введите 2 целых положительных: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine()); 
int sum = Akkerman(a, b); 
Console.Write($"m={a}, n={b} -> A({a},{b}) = {sum}"); 
int Akkerman(int n, int m) 
{ 
    if (n == 0) return m + 1; 
    else 
    if (n != 0 && m == 0) return Akkerman(n - 1, 1); 
    else return Akkerman(n - 1, Akkerman(n, m - 1)); 
}