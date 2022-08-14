// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillArray (int[]array)
{
    int index=0;
    while (index < array.Length)
    {
        array[index]=new Random().Next(100,1000);
        index++;
    }
}

void PrintArray (int[]array)
{
    int index=0;
    while (index < array.Length)
    {
        Console.Write($"{array[index]}, ");
        index++;
    }
}



int[]array = new int [12];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

int result=0;
for (int i=0; i<array.Length; i++)
    if (array[i] % 2 == 0)
    {
        result = result + array[i];
    }
Console.WriteLine("Сумма четных чисел в массиве:");    
Console.WriteLine(result); 

int find=0;
for (int index=0; index<array.Length; index++)
    if (array[index] %2!=0)
    {
        find = find + array[index];
    }
Console.WriteLine("Сумма нечетных чисел в массиве:");    
Console.WriteLine(find); 