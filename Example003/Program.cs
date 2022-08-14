// Написать программу замену элементов массива на противоположные
void FillArray (int[]array)
{
    int index=0;
    while (index < array.Length)
    {
        array[index]=new Random().Next(-99,100);
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

void ChangeArray (int[]array)
{
    int index=0;
    while (index < array.Length)
    {
        array[index] = -array[index];
        index++;
    }
}

int[]array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");
ChangeArray(array);
PrintArray(array);
