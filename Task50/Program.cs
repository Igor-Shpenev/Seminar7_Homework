// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] MatrixArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(-10, 10);          // Заполняем двумерный массив рандомными числами
        }
    }
    return array;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)            // Выводим на экран двумерный массив
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ElementSearch(int rows, int columns, int[,] array)
{
    for (int i = 0; i <= rows; i++)
    {
        for (int j = 0; j <= columns; j++)                         
        {
            if (rows == i & columns == j) Console.Write($"This element is {array[rows, columns]} "); // Ищем совпадение индексов с теми, которые ввел пользователь

        }
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr = MatrixArray(4, 5);
PrintArr(arr);
if (rows >= arr.GetLength(0) || columns >= arr.GetLength(1)) Console.WriteLine("This element does not exist");
else ElementSearch(rows, columns, arr);    

