// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetSecondDigit(int number)
{
    return (number / 10) % 10;
}


    int number;
    Console.WriteLine("Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    int secondDigit = GetSecondDigit(number);
    if (number < 100 || number >= 1000)
    Console.WriteLine($"Вы ввели не трехзначное число, повторите попытку");
    else
    Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
