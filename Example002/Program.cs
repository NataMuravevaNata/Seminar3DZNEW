// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void FillArray (int[]arrayColection)
{
    int index=0;
    while (index < arrayColection.Length)
    {
        arrayColection[index]=new Random().Next(0,10);
        index++;
    }
}

void PrintArray (int[]arrayColection)
{
    int index=0;
    while (index < arrayColection.Length)
    {
        Console.Write($"{arrayColection[index]}, ");
        index++;
    }
}

int[]array = new int [12];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

int result=0;
for (int i=0; i<array.Length; i++)
    if (array[i] < 0)
    {
        result = result + array[i];
    }
Console.WriteLine("Сумма отрицательных чисел в массиве:");    
Console.WriteLine(result); 

int find=0;
for (int index=0; index<array.Length; index++)
    if (array[index] > 0)
    {
        find = find + array[index];
    }
Console.WriteLine("Сумма положительных чисел в массиве:");    
Console.WriteLine(find); 
 

