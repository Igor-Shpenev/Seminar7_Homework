// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] MatrixArray(int a, int b)
{
    double[,] array = new double[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(1, 11);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double [] ArithmeticMean(double[,] array)
{
    double [] qwearr = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            qwearr[j] += array[i, j] / array.GetLength(0);
        }
        Console.WriteLine($"Arithmetic mean of the column № {j + 1} = {Math.Round(qwearr[j], 1)}");
    }
    
    return qwearr;
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] arr = MatrixArray(rows, columns);
PrintArr(arr);
ArithmeticMean(arr);