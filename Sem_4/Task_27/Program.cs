// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string getNumber(string text)
{
  System.Console.Write(text);
  return Console.ReadLine();
}

int GetSumElements(string Num) 
{
  int len = Num.Length;
  int result = 0;
  for (int i = 0; i < len; i++)
  {
    int convertedNum = Convert.ToInt32(Convert.ToString(Num[i]));
    result = result + convertedNum;
  }
  return result;
}

var num = getNumber("Введите число А: ");
int res = GetSumElements(num);
System.Console.WriteLine($"Сумма цифр в числе {num} = {res}");

