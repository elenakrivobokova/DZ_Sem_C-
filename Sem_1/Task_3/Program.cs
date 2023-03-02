// Задача 6: Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = N % 2;

if (result == 0)
{
  Console.WriteLine($"{N} - является четным");
}
else
{
  System.Console.WriteLine("Не является четным числом");
}
