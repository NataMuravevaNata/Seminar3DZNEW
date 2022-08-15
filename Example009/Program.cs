// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
        
int[]array={1, 14, 5, 16, 74, 2, 5, 4, 69, 13};        
int n = array.Length;
int i = 0;
while (i<n)
{
    Console.WriteLine(array[i]);
    i++;
}
Console.WriteLine("Находим максимальное значение данного массива:");
int max = array[0];
if (array [1]>max) max = array[1];  
if (array [2]>max) max = array[2]; 
if (array [3]>max) max = array[3]; 
if (array [4]>max) max = array[4];    
if (array [5]>max) max = array[5]; 
if (array [6]>max) max = array[6]; 
if (array [7]>max) max = array[7]; 
if (array [8]>max) max = array[8];
if (array [9]>max) max = array[9]; 
Console.WriteLine(max);

Console.WriteLine("Находим минимальное значение данного массива:");
int min = array[0];
if (array [1]<min) min = array[1];  
if (array [2]<min) min = array[2]; 
if (array [3]<min) min = array[3]; 
if (array [4]<min) min = array[4];    
if (array [5]<min) min = array[5]; 
if (array [6]<min) min = array[6]; 
if (array [7]<min) min = array[7]; 
if (array [8]<min) min = array[8];
if (array [9]<min) min = array[9]; 
Console.WriteLine(min);

Console.WriteLine("Находим разницу между максимальным значением и минимальным:");
Console.WriteLine(max-min);