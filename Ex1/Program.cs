int [] CreateRandomArray(int length)
{
    int [] array = new int [length];
    Random N = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = N.Next(100, 999);
        Console.WriteLine(array[i]);
    }
    return array;
}

int [] arr1 = CreateRandomArray(5);

int count = 0;
for (int i = 0; i < 5; i++)
{
    if (arr1[i] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.Write("Количество четных чисел в массиве: ");
Console.WriteLine(count);