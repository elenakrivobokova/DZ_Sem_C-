// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int InputNumber(string str) 
{
  System.Console.Write(str);
  return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату Х1: ");
int y1 = InputNumber("Введите координату Y1: ");
int z1 = InputNumber("Введите координату z1: ");

int x2 = InputNumber("Введите координату Х2: ");
int y2 = InputNumber("Введите координату Y2: ");
int z2 = InputNumber("Введите координату z2: ");


System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)), 2));