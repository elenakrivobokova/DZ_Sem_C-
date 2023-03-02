// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int PowNumber(int num, int degree)
{
  int result = 1;
  for (int i = 1; i <= degree; i++)
  {
    result = result * num;
  }
  return result;
}
int A = GetNumber("Введите число A: ");
int B = GetNumber("Введите число B: ");
if (B > 0)
{
  System.Console.WriteLine($"Число {A} в степени {B} = {PowNumber(A, B)}");
}
else
{
  System.Console.WriteLine($"Число {B} не является натуральным");
}