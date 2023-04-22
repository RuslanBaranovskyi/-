// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N:");
int N = Convert.ToInt32(Console.ReadLine());

if ((N > 0) && (M > 0))
{
    int result = SumNumbers(M, N);
    Console.WriteLine(result);
}
else
    Console.WriteLine("Некорректный ввод.");

int SumNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        return numM + SumNumbers(numM + 1, numN);
    }
    else if (numM > numN)
    {
        return numM + SumNumbers(numM - 1, numN);
    }
    else 
    {
        return numM;
    }
}
