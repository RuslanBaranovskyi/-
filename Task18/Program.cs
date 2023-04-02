// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
string Q = Console.ReadLine();

string result = Quarter(Q);
Console.WriteLine(result);

string Quarter (string QU)
{
if(QU == "1") return "x > 0 ; y > 0";
if(QU == "2") return "x < 0 ; y > 0";
if(QU == "3") return "x < 0 ; y < 0";
if(QU == "4") return "x > 0 ; y < 0";
return "0";
}