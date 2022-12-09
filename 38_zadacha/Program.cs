// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] startArray = GetArray(5, 5, 2);
Console.WriteLine($"[{String.Join(" ", startArray)}] -> {Differense(startArray):f3}");

double[] GetArray(int size, double sizeValue, double startValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble()*sizeValue + startValue;
    }
    return result;
}

double Differense(double[] array)
{
    double minnumber = array[1];
    double maxnumber = array[1];
    double dif = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minnumber) minnumber = array[i];
        for (int j = 0; j < array.Length; j++)
        {
          if (array[j] > maxnumber) maxnumber = array[j];
        }
    }
    dif = maxnumber - minnumber;
    return dif;
}
