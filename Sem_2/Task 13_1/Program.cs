// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

string array = Convert.ToString(num);

int n = array.Length;
int index = 2;

if (n > 2)
{
  System.Console.WriteLine(array[index]);
}
else
{
  System.Console.WriteLine("Число не трехзначное");
}