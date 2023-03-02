// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    var rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
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

void SelectionRowsToLower(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(1) - 1; n++)
            {
                if (matrix[i, n] < matrix[i, n + 1])
                {
                    int temporary = matrix[i, n + 1];
                    matrix[i, n + 1] = matrix[i, n];
                    matrix[i, n] = temporary;
                }
            }
        }
    }
}

int rows = ReadInt("Number of rows: ");
int cols = ReadInt("Number of columns: ");
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
SelectionRowsToLower(myMatrix);
PrintMatrix(myMatrix);


