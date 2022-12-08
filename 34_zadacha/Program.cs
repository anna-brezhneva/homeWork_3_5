// See https://aka.ms/new-console-template for more information
Console.Clear();
int[] startArray = TripleDigitsArray(8, 100, 999);
Console.WriteLine($"[{String.Join(" ", startArray)}] -> {Count(startArray)}");


int[] TripleDigitsArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int Count(int[] array)
{
    int count = 0;
    int i = 0; 
    while (i < array.Length)
    if (array[i] % 2 == 0)
    {
        count += 1;
        i++;
    }
    else
    {
        i++;
    }
    return count;
}