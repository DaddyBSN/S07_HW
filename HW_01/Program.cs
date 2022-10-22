// Написать программу, упорядовачивания по убыванию элементов каждой строки двумерного массива.

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

void DecreasingMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temporary = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temporary;
                }
            }
        }
    }
}

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
DecreasingMatrix(matrix);
PrintMatrix(matrix);