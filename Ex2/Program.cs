int [] CreateRandomArray(int length)
{
    int [] array = new int [length];
    Random N = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = N.Next(-100, 100);
        Console.WriteLine(array[i]);
    }
    return array;
}

int [] arr1 = CreateRandomArray(5);

int sum = 0;
for (int i = 0; i < 5; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + 0;
    }
    else sum = sum + arr1[i];
}
Console.Write("Сумма элементов на нечетных позициях: ");
Console.WriteLine(sum);