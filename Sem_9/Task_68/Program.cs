// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

Metka:
int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
if (n < 0 || m < 0)
{
    System.Console.WriteLine("Число должно быть неотрицаптельным. Повторите ввод!");
    goto Metka;
}
int result = FunctionAkkerman(m, n);
System.Console.Write($"Функция Аккермана = {result} ");

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionAkkerman(int m, int n)
{
    if (m == 0 && n > 0) return n + 1;
    else if (n == 0 && m > 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}