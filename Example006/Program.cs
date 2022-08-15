// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray (int[]array)
{
    int index=0;
    while (index < array.Length)
    {
        array[index]=new Random().Next(0,1000);
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


int[]array = new int [123];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

int count=0;
int i =1;
    while (i<array.Length)
    {
        if (array [i] >=10 && array[i] <= 99)
        count = count + i;
        i++;
    }
    
Console.WriteLine("Количество элементов из отрезка от 10 до 99:");    
Console.WriteLine(count); 


