//Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.


System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Print(n, 1);

void Print(int num, int a)
{
    if (a <= num)
    {
        Print(num, a += 1);
        System.Console.Write((a - 1) + "\t");

    }
    return;
}