// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.


int[] CreateArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i + 1}:");
        arr[i] =  Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();

}

int CountPositiveNumbers( int [] arr)
{
    int positiveCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positiveCount++;
        }
    }
    return positiveCount;
}


Console.Write("Введите количество чисел: ");
int NumbersAmount = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(NumbersAmount);
Console.WriteLine("Исходный массив:");
PrintArray(array);

int PositiveCount = CountPositiveNumbers(array);
Console.WriteLine($"Количество чисел больше 0: {PositiveCount}");




