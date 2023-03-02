// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
  Console.Write("max = " + a);
}

else if (b > a && b > c)
{
  Console.Write("max = " + b);
}
else
{
  Console.Write("max = " + c);
}