// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] MatrixArray(int a, int b)
{
    double[,] array = new double[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
    return array;
}

void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] arr = MatrixArray(rows, columns);
PrintArr(arr);
