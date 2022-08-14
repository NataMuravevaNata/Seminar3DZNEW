// Определить, присутствует ли в заданном массиве, некоторое число

void FillArray (int[]array)
{
    int index=0;
    int Length = array.Length;
    while (index < Length)
    {
        array[index]=new Random().Next(1,100);
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

void findArray (int[]array)
{
    Console.WriteLine();
    Console.WriteLine("Введите искомое число");
    int find =int.Parse(Console.ReadLine()?? "0");
    int i=0;
    bool contains = false;
    while (i < array.Length)
    {
        if (array [i]==find)
        {
            Console.Write("Искомое число найдено");
            contains=true;
            break;
        }
        i++;
    }
    if (contains==false)
    Console.Write("Искомое число не найдено");
}
int[]array = new int [20];
FillArray(array);
PrintArray(array);
findArray (array);