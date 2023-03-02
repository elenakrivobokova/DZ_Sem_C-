// Задача 50: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 100);
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

int RowsColsIndex(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void SearchElement(int[,] matrix, int rowInd, int columnInd)
{
    if(rowInd <= matrix.GetLength(0) && columnInd <= matrix.GetLength(1))
    {
        System.Console.WriteLine(matrix[rowInd,columnInd]);
    }
    else
    {
        System.Console.WriteLine("The element does not exist in this matrix");
    }
}

int rows = ReadInt("Enter the number of rows in the matrix: ");
int cols = ReadInt("Enter the number of columns of the matrix: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);

int rowIndex = RowsColsIndex("Enter the index of the element row: ");
int columnIndex = RowsColsIndex("Enter the index of the element column: ");

SearchElement(myMatrix, rowIndex, columnIndex);