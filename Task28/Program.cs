﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine($"Введите целое число N:");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 0)
{
    int result = Factorial(numberA);
    Console.WriteLine($"Резултат вычисления факториала :{result}");
}
else Console.WriteLine($"Введено отрицательное число!");

int Factorial(int num)
{
    int resultFactorial = 1;
    for (int i = 1; i <= num; i++)
    {
        checked{resultFactorial *= i;};
    }
    return resultFactorial;
}