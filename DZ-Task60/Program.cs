// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.  
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
// Массив размером 2 x 2 x 2 
// 66(0,0,0) 25(0,1,0) 
// 34(1,0,0) 41(1,1,0) 
// 27(0,0,1) 90(0,1,1) 
// 26(1,0,1) 55(1,1,1) 
 
 
int[,,] matrix1 = CreateArray(2,2,2); 
int[,,] CreateArray(int i1, int j1, int r1) 
{ 
    int[,,] array = new int[i1,j1,r1]; 
    Random rnd = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        for (int r = 0; r < array.GetLength(2); r++) 
        { 
            array[i,j,r]=rnd.Next(0, 10 + 1); 
            Console.WriteLine($"{array[i, j, r]}({i},{j},{r})"); 
        } 
    } 
  } 
    return array; 
}