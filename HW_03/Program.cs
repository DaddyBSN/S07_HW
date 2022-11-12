// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

int sumRow = 0;
int minLine = 0;
int min = 999;
int temp = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp += matrix[i, j];
        sumRow = temp;
    }
    temp = 0;

    if (min > sumRow)
    {
        min = sumRow;
        minLine = i + 1;
    }
    Console.WriteLine($"Сумма {i + 1} строки = {sumRow} ");
}
Console.WriteLine($"Минимальная строка {minLine} её сумма = {min} ");