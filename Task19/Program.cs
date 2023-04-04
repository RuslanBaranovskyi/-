// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int number = ReadInt("Введите пятизначное число: ");


Palindrom(number);

void Palindrom(int n)
{
   
   int firstDigit = n / 10000;
   int secondDigit = (n / 1000) % 10; 
   int fourthDigit = (n / 10) % 10; 
   int fifthDigit = n % 10;
   if ((firstDigit == fifthDigit) && (secondDigit == fourthDigit))
   Console.WriteLine("Введенное число является палиндромом");
   else Console.WriteLine("Введенное число не является палиндромом");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}