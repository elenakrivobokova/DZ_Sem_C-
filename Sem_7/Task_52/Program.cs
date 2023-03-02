// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 11);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

int[,] myMatrix = new int[,]
{
{1, 4, 7, 2 },
{5, 9, 2, 3 },
{8, 4, 2, 4 },
};

void GetAverageForColumn(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        double averageSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        averageSum = Math.Round(sum / matrix.GetLength(0), 1);
        System.Console.Write(averageSum + "| ");
    }
}

// int rows = ReadInt("Enter the number of rows in the matrix: ");
// int cols = ReadInt("Enter the number of columns of the matrix: ");
// System.Console.WriteLine();
// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);
// System.Console.WriteLine();
GetAverageForColumn(myMatrix);