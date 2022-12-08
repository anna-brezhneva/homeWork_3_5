// Задача № 36. Задать массив. Найти сумму элементов, стоящих на нечетных позициях.

Console.Clear();
int[] startArray = GetArray(8, -10, 20);
Console.WriteLine($"[{String.Join(" ", startArray)}] -> {Summa(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int Summa(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}