// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите целое положительное число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N:");
int N = Convert.ToInt32(Console.ReadLine());

if ((N > 0) && (M > 0))
{
    int result = FunctionAckermann(M, N);
    Console.WriteLine($"Результат вычисления функции Аккермана:  {result}");
}
else
    Console.WriteLine("Некорректный ввод.");


int FunctionAckermann(int n, int m)
{
    if (n == 0)
    {
        return (m + 1);
    }
    else if (m == 0)
    {
        return FunctionAckermann(n - 1, 1);
    }
    else
        return FunctionAckermann(n - 1, FunctionAckermann(n, m - 1));
}