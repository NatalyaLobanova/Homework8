// Задача 62. Заполните спирально массив 4 на 4.

int[,] matrix = new int[4, 4];
int temp = 1;
int i = 0; 
int j = 0;

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
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
        else
        i--;
    }         
}

FillMatrix(matrix);
PrintMatrix(matrix);