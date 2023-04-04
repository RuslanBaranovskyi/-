// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

int numberA = ReadInt("Введите число: ");
int numberB = ReadInt("Введите натуральную степень: ");

if (numberB<1)
Console.Write("Число B должно быть натуральным\n");
else 
ToDegree(numberA, numberB);

void ToDegree(int a, int b)
{

    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}