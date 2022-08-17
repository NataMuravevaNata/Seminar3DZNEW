// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Введите размер массива: ");
void FillArray (int[]array)
{
    int index=0;
    while (index < array.Length)
    {
        array[index]=new Random().Next(0,10);
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
void Prodact(int[] array)
{      
int result = 0;
int i = 0;
int j = 9;
while (i<array.Length/2)
{
    result=array[i]*array[j];
    Console.WriteLine($"Произведение пары: {array[i]} * {array[j]} = {result}");  
    i++;
    j--;
    if (i==j)
    break;
}
}

int[]array = new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");
Prodact(array);
