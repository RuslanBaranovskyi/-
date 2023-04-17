// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите номер строки искомого элемента ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента ");
int y = Convert.ToInt32(Console.ReadLine());

if (y < 0 || x < 0 || m < 0 || n < 0) Console.WriteLine("Число не может быть отрицательным ");


int[,] matrixX = CreateMatrixRndInt(m, n, -10, 10);
PrintArray(matrixX);
Console.WriteLine($"Элемент с введенными координатами равен {FindElement(matrixX)}");


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

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.Length - 1) Console.Write($"{matrix[i, j],3} ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }

}
int FindElement(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == x || j == y);
        }
    }
    return (matrix[x,y]);
}






