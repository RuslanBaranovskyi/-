// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
string s=Console.ReadLine();

string result = Palindrom(s);
Console.WriteLine(result);

string Palindrom(string sStr)
{

for(int i = 0; i < s.Length;)

   if(sStr[0] == sStr[4] && sStr[1] == sStr[3]) return "да";
   else 
   return "нет";
    
}

