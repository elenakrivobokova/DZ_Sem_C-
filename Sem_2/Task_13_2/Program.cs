// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number > 99 && number < 1000)
{
  System.Console.WriteLine("Третье число: " + (number % 10));
}
else if (number >= 1000) // В этом блоке нахожу разрядность заданного числа. Затем делю число до тысячных и отсекаю остаток от деления (третью цифру) через 
{
  int count = 0;
  int digitNumber = number;
  while (digitNumber > 0)
  {
    digitNumber = digitNumber / 10;
    count++;
  }
  int result = number / Convert.ToInt32(Math.Pow(10, count - 3));
  System.Console.WriteLine("Третья цифра: " + (result % 10));
}
else
{
  System.Console.WriteLine("Число не трехзначное");
}

