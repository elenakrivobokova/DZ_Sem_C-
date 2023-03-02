// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

System.Console.WriteLine("Введите пятизначное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 9999 && N < 100000)
{
  string array = Convert.ToString(N);

  if (array[0] == array[4] && array[1] == array[3])
  {
    System.Console.WriteLine("Это палиндром!");
  }
  else
  {
    System.Console.WriteLine("это не палиндром");
  }
}
else
{
  System.Console.WriteLine("Число не пятизначное. Попробуйте еще раз!");
}


//альтернативное решение через строку
// System.Console.WriteLine("Введите пятизначное число: ");
// string num= Console.ReadLine();

// if(num[0]==num[4]&&num[1]==num[3])
// {
//   System.Console.WriteLine("Это палиндром");
// }
// else
// {
//   System.Console.WriteLine("Это не палиндром");
// }


//альтернативное математическое решение
// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
// {
//   System.Console.WriteLine("Число является палиндромом");
// }
// else
// {
//   System.Console.WriteLine("Число не является палиндромом");
// }

System.Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
// if (num[0] == num[4] && num[1 == num[3]])
// {
//   System.Console.WriteLine("Это палиндром");
// }
// else
// {
//   System.Console.WriteLine("Это не палиндром");
// }
int convertedNum = Convert.ToInt32(Convert.ToString(num[i]));//конвертация из char в string и потом в int
System.Console.WriteLine(convertedNum);
