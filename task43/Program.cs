// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
double numBFirst = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double numKFirst = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double numBSecond = Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double numKSecond = Convert.ToDouble (Console.ReadLine());

double [] res = SearchPointCoordinat(numBFirst,numKFirst, numBSecond,numKSecond);
Console.WriteLine($"Прямые пересекутся в точке с координатами ({res[0]}, {res[1]})");


double [] SearchPointCoordinat (double b1,double k1, double b2, double k2)
{
    double x= (b2-b1)/ (k1-k2);
    double y =  k1*x+b1;
 double [] pointCoord = {Math.Round (x,2),Math.Round (y,2)};
 return pointCoord;
}