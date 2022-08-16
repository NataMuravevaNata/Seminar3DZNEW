// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] array = {1, 5, 8, 7, 12, 24, 4, 7, 9, 1, 12};
int n = array.Length;
int counter = 1;
int sum=0;
Console.WriteLine("сумма чисел стоящих на нечетной позиции:"); 

while (counter < n)
{
    sum = sum+1;
    counter=counter +2;
}
Console.WriteLine(sum);