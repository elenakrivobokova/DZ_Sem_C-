// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, 
// k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumber(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

void Coordinate(double k1, double k2, double b1, double b2)
{
  var x = (b2-b1)/(k1-k2);
  System.Console.WriteLine(x);
  var y = k1 * x + b1;
  System.Console.WriteLine(y);
}

double k1 = GetNumber("Введите число k1: ");
double k2 = GetNumber("Введите число k2: ");
double b1= GetNumber("Введите число b1: ");
double b2 = GetNumber("Введите число b2: ");
Coordinate(k1, k2, b1, b2);

