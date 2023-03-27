// 9. Напишите программу, которая выводит
// 1. вывод случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.

// 78 -> 8 // 78 / 10 = 7.8
// 12-> 2
// 85 ->  // 80 % 10 = 5

int numberRandom = new Random().Next(10,100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {numberRandom}");

int firstDigit = numberRandom / 10;
int secondDigit = numberRandom % 10;

// if (firstDigit> secondDigit)
// {
//      Console.WriteLine ($"Наибольшая цифра числа => {firstDigit}");
// }
// else 
// {
// Console.WriteLine ($"Наибольшая цифра числа => {secondDigit}");
// }

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine ($"Наибольшая цифра числа => {secondDigit}");

