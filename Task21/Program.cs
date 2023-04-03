// Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит
//  расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z2:");
int z2 = Convert.ToInt32(Console.ReadLine());
double findingDistance = FindDistance(x1,x2,y1,y2,z1,z2);

Console.WriteLine($"Расстояние между точкой A и B = {Math.Round(findingDistance ,2, MidpointRounding.ToZero)}");

double FindDistance(int x1Coordinata, int x2Coordinata, int y1Coordinata, int y2Coordinata,int z1Coordinata, int z2Coordinata)
{
    int firstCatet = x2Coordinata - x1Coordinata;
    int secondCatet = y2Coordinata - y1Coordinata;
    int thirdCatet = z2Coordinata - z1Coordinata;
    double distance = Math.Sqrt(firstCatet*firstCatet+secondCatet*secondCatet+thirdCatet*thirdCatet);
    return distance;
}

