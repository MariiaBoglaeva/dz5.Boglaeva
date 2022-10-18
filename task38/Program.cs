// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double [] array = CreateArrayRndDouble (size:5, min:-5, max:10);
PrintArrayDouble (array);
double max = SearchMaxElement(array);
double min = SearchMinElement(array);
double result =  Math.Round(max-min,2);
Console.WriteLine($"Разницу между максимальным {max} и минимальным {min} элементами массива = {result}");


double SearchMaxElement (double[]arr)
{
    double maxEl= arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]> maxEl) maxEl=arr[i];
}
return maxEl;
}

double SearchMinElement (double[] arr)
{
    double minEl= arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]< minEl) minEl=arr[i];
}
return minEl;
}

double [] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double number = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(number, 2);
    }
    return array;
}

void PrintArrayDouble(double[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        System.Console.Write($"{arr[i]}; ");
    }
    System.Console.WriteLine($"{arr[arr.Length - 1]}]");
}
