// // 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 4. 3 -> Среда
// 5. 5 -> Пятница
// // 6.

Console.WriteLine("Введите день недели : ");
string number1 = (Console.ReadLine());
if (number1 == "1")
{
    Console.WriteLine("Понедельник");
}
if (number1 == "2")
{
    Console.WriteLine("Вторник");
}
if (number1 == "3")
{
    Console.WriteLine("Среда");
}
if (number1 == "4")
{
    Console.WriteLine("Четверг");
}
if (number1 == "5")
{
    Console.WriteLine("Пятница");
}
if (number1 == "6")
{
    Console.WriteLine("Суббота");
}
if (number1 == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}