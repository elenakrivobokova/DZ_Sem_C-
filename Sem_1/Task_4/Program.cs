// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 1)
{
  for (int i = 1; i <= N; i++)
  {
    int result = i % 2;
    if (result == 0)
      System.Console.Write(i + " ");
  }
}
else
{
  System.Console.WriteLine("Недопустимое значение");
}