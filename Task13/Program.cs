// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void FillArray(int[] number)
{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine("Введите число: ");
        number[index] = Convert.ToInt32(Console.ReadLine());
    }
}
  void GetThirdDigit(int[] number, int thirdDigit)
{
    int count = number.Length;
    int index = 0;
    if (number.Length < 3);
    {
        Console.WriteLine("Третьей цифры нет");
    }
}


