// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void FillMatrixRandom(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 5);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void MinSumRowNumber(int[,] matrix)
{
    int minSum = 0;
    int sumRow = 0;
    int result = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSum += matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if (sumRow < minSum)
        {
            sumRow = minSum;
            result = i;
        }
        sumRow = 0;
    }
    System.Console.WriteLine($"The row is {result + 1}");
}

int[,] table = new int[3, 4];
FillMatrixRandom(table);
PrintMatrix(table);
System.Console.WriteLine();
MinSumRowNumber(table);

