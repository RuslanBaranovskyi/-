// Задача 23. Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string Spreadsheet(int nNum)
{
string spreadsheetResult = "________\n";
for (int i = 1; i <= nNum; i++)
{
spreadsheetResult = spreadsheetResult + $"|{i} | {i * i * i}| \n";
}
spreadsheetResult = spreadsheetResult+ "-----------";
return spreadsheetResult;
}

Console.Write("Введи число N:");
int n = Convert.ToInt32(Console.ReadLine());

string result = Spreadsheet(n);
Console.Write(result);