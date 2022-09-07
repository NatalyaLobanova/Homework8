// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int m = 4;
int n = 5;
int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[m, n];

void FillMatrix(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = new int[m, n];
void MultiplicationMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
        }
    }
}

FillMatrix(firstMatrix);
FillMatrix(secondMatrix);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
MultiplicationMatrix(resultMatrix);
PrintMatrix(resultMatrix);
