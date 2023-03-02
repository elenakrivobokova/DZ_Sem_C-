// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введите цифру от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
  System.Console.WriteLine("Ура! Это выходной день!!!");
}
else if (day >= 0 && day < 6)
{
  System.Console.WriteLine("Увы...это не выходной день");
}
else
{
  System.Console.WriteLine("Заданное число не является днем недели");
}
