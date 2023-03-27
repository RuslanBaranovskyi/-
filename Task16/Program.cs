// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1:");
int firstNum = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int secondNum = int.Parse(Console.ReadLine());

bool result = IsFirstSquareSecond(firstNum, secondNum);

string res = result ? "Одно число является квадратом другого" : "Число не является квадратом другого";
Console.WriteLine(res);

bool IsFirstSquareSecond(int firstNumber, int secondNumber)
{
    return firstNumber == secondNumber * secondNumber || secondNumber == firstNumber * firstNumber;
}