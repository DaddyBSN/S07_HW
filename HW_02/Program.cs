// Написать программу, которая в двумерном массиве заменяет строки на столбцы.

Console.WriteLine("Введи количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введи количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(1, 9);
    }
    return matrix;
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

int[,] matrix = FillMatrix(m, n);
int[,] reverseMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
        reverseMatrix[i, j] = matrix[j, i];
}

PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(reverseMatrix);