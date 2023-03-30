// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomNumber = new Random().Next(100, 1000);
int newNumber = DeleteSecondDigit(randomNumber);

Console.WriteLine($"Рандомное трехзначное число {randomNumber}");
Console.WriteLine($"Полученное двухзначное число{newNumber}");

int DeleteSecondDigit(int randomNum)
{
    int firstDigit = randomNum / 100;
    int thirdDigit = randomNum % 10;
    int newNumber = (firstDigit * 10) + secondDigit;

    return newNumber;
}
