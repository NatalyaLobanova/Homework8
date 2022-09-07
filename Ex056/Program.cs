// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int m = 6;
int n = 4;
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);


int SumLineNumbers(int[,] matrix, int i)
{
    int sumLine = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sumLine += matrix[i, j];
        }
        return sumLine;      
}
int minSumLine = 0;
int sumLine = SumLineNumbers(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSumLine = SumLineNumbers(matrix, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"{minSumLine + 1} - строка с наименьшей суммой элементов, сумма равна {sumLine}");


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



