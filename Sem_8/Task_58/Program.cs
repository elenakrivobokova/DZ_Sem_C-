// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

void FillMatrixRandom(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int l = 0; l < matrix2.GetLength(1); l++)
        {
            resultMatrix[i, l] = 0;
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                resultMatrix[i, l] += matrix1[i, j] * matrix2[j, l];
                
            }
        }
    }
    return resultMatrix;
}

int[,] arr1 = new int[3, 4];
FillMatrixRandom(arr1);
PrintMatrix(arr1);
System.Console.WriteLine();

int[,] arr2 = new int[4, 2];
FillMatrixRandom(arr2);
PrintMatrix(arr2);
System.Console.WriteLine();

PrintMatrix(MultiplicationMatrix(arr1, arr2));




