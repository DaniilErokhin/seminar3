//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int GetQuadrant (int x, int y)
{
    int quadNum = 0;
    if(x > 0 && y > 0) quadNum = 1;
    else if(x < 0 && y > 0) quadNum = 2;
    else if(x < 0 && y < 0) quadNum = 3;
    else if(x > 0 && y < 0) quadNum = 4;
    
    return quadNum;
}
*/
/*
int GetQuadrant (int x, int y)
{
    int quadNum = 0;
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
*/
/*
int GetQuadrant(int x, int y)
{
     int quadNum = 0;
    if(x > 0 && y > 0) quadNum = 1;
    else if(x < 0 && y > 0) quadNum = 2;
    else if(x < 0 && y < 0) quadNum = 3;
    else if(x > 0 && y < 0) quadNum = 4;
    
    return quadNum;
}

Console.Write("Input a first coordinate: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second coordinate: ");
int yA = Convert.ToInt32(Console.ReadLine());

int result = GetQuadrant(xA, yA);

if(result == 0)
{
    Console.WriteLine("Your point is on axis: ");
}
else
{
    Console.WriteLine($"Your point is on {result} quadrant");
}
*/
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void GetQuadrant(int quadNum)
{
    if(quadNum == 1) Console.Write("x > 0 && y > 0");
    else if(quadNum == 2) Console.Write("x < 0 && y > 0");
    else if(quadNum == 3) Console.Write("x < 0 && y < 0");
    else if(quadNum == 4) Console.Write("x > 0 && y < 0");
}
Console.WriteLine("Input a quadNum: ");
int quadNum = Convert.ToInt32(Console.ReadLine());
GetQuadrant(quadNum);
*/
//Получить число N на входе и вывести квадраты чисел от 1 до N
/*
void PrintSq(int N)
{
    int i = 1;
    while(i <= N)
    {
        Console.Write(i * i + " ");
        i++;
    }
}
Console.WriteLine("inpit a number: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintSq(N);
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Length(double x1, double y1, double x2, double y2)
{
    double L1 = x2 - x1;
    double L2 = y2 -y1;
    double result = Math.Sqrt(Math.Pow(L1,2) + Math.Pow(L2,2));
    return result;
}
Console.Writeline("Line.Length " + Math.Round(Length(x1, y1, x2, y2)));