// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 99 && N < 1000)
{
  int result = (N / 10);
  System.Console.WriteLine("Вторая цифра:" + (result % 10));
}
else
{
  System.Console.WriteLine("Число не трехзначное");
}