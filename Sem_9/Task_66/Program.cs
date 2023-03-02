// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
if (M < N) // Если первое число больше второго, то меняем их местами
{
    int temp = M;
    M = N;
    N = temp;
}
  System.Console.WriteLine(Print(M, N));


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Print(int numN, int numM)
{
    int result = numN;
    if (numN > numM)
    {
        return result + Print(numN-1, numM);
    }
    return result;
}

// 2-й вариант метода

// int Print(int numM, int numN)
// {
//     int result = numM;
//     if (numM >= numN)
//     {
//         return result;
//     }
//     return result + Print(numM+1, numN);
// }