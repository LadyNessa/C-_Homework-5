double [] CreateRandomArray(int length)
{
    double [] array = new double [length];
    Random N = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = N.NextDouble() * 50;
        Console.WriteLine(array[i]);
    }
    return array;
}

double [] arr1 = CreateRandomArray(5);

double max = arr1[0];
double min = arr1[0];
double diff = 0;
for (int i = 1; i < 5; i++)
{
    if (arr1[i] > max) max = arr1[i];
    if (arr1[i] < min) min = arr1[i];
}

diff = max - min;
Console.Write("Максимальное число: ");
Console.WriteLine(max);
Console.Write("Минимальное число: ");
Console.WriteLine(min);
Console.Write("Разница между максимальным и минимальным: ");
Console.WriteLine(diff);