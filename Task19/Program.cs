// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число");
int[] n = Convert.ToInt32(Console.ReadLine());


int result = Polindrom(n);
Console.WriteLine(result);


int Polindrom (int nNum)
{
    int len = n.Length;
    for (int i = 0; i < len; i++)
    {
if (nNum[0] = nNum[4] && Nnum[2] = Nnum[3])
return "да";
return "нет";
}
}


