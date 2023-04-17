// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:

//      -0    -1    -2    -3
//   0-  1     4     7     2
//   1-  5     9     2     3
//   2-  8     4     2     4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateMatrixRndInt(row, col, -10, 10);
PrintArray(resultArray);

GetElem(resultArray);


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)

{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i, j],3} ");
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }

}

void GetElem(int[,] resultArray)
{ 

    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            sum = sum + resultArray[i, j];
        }
        sum = sum / resultArray.GetLength(0);
        Console.WriteLine($"Среднее арифметическое {j} столбца = {sum} ");
        
    }
}

