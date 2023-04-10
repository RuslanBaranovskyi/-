// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size,double min, double max)
{
double[] arr = new double[size];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.NextDouble() * (max - min) + min;
}
return arr;
}
void PrintArrayDouble (double[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{Math.Round(arr[i] ,2, MidpointRounding.ToZero)}  ");
    }
    Console.WriteLine();
}

double MinDigitArray(double[] arr)
{
   double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    { 
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
  
  double MaxDigitArray(double[] arr)
{
   double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    { 
        if (arr[i] > max) max = arr[i];
    }
    return max;
        
}
 double DifferenceMinMax (double minim, double maxim)
 {
    double difference = (maxim - minim);
    return difference;
    
 }

double [] array = CreateArrayRndDouble(5, 0, 10);
PrintArrayDouble(array);
double Minimal = MinDigitArray(array);
Console.WriteLine($"Минимальное число массива = {Math.Round(Minimal,2, MidpointRounding.ToZero)}");
double Maximal = MaxDigitArray(array);
Console.WriteLine($"Максимальное число массива = {Math.Round(Maximal,2, MidpointRounding.ToZero)}");
double Differ = DifferenceMinMax(Minimal, Maximal);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(Differ,2, MidpointRounding.ToZero)}");