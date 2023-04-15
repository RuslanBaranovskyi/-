// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



 Console.WriteLine("Введите номер строки ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца ");
    int y = Convert.ToInt32(Console.ReadLine());

    int[,] matrixX = CreateMatrixRndInt(4, 4, 0, 10);
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
            if (!(i +1 != x && j+1 != y)) ;
        }
    }
    return (matrix[x-1,y-1]);
}






