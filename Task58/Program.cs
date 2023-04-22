// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк таблицы 1");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы 1");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateArrayMatrix(m, n, 1, 10);

Console.WriteLine("Введите количество строк таблицы 2");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы 2");
int p = Convert.ToInt32(Console.ReadLine());

int[,] matrix2 = CreateArrayMatrix(k, p, 1, 10);

Console.WriteLine("Первая матрица:");
PrintArray(matrix1);

Console.WriteLine("Вторая матрица:");
PrintArray(matrix2);

Checkmatrix(n,k);

int [,] result = MultiplyMatrix(matrix1, matrix2);

Console.WriteLine("Результат умножения:");

PrintArray(result);


int[,] CreateArrayMatrix(int rows, int colum, int min, int max)
{
    int[,] arr = new int[rows, colum];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
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

void Checkmatrix (int i, int j)
{
if (i==j) 
Console.WriteLine();
else Console.WriteLine("Невозможно умножить данные матрицы");
}

int[,] MultiplyMatrix(int[,]arr1, int[,]arr2)
{
int[,] newmatrix = new int[arr1.GetLength(0),arr2.GetLength(1)];

for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                newmatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newmatrix;
}











