﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine($"Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите первое число для деления:");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите второе число для деления:");
int secondNum = int.Parse(Console.ReadLine());

bool result = IsMultipleTwoNumbers(num, firstNum, secondNum);
Console.WriteLine(result? "Число кратное данным числам":"Число не кратное данныи числам");

bool IsMultipleTwoNumbers(int number, int firstNumber, int secondNumber)

{
    return number % firstNumber == 0 && number % secondNumber == 0;

}