// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцы: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] Get2DArray(int m, int n)
// {
//     double[,] matrix = new double[m, n];
//     for (int i = 0; i < m; i++) 
//     {
//         for (int j = 0; j < n; j++) 
//         {
//             matrix[i, j] = Math.Round (new Random().NextDouble(), 2);  // округлил для лучшего вида
//         }
//     }
//     return matrix;
// }

// void Print2DArray(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             Console.Write(matrix[i, j] + "\t");   
//         }
//         Console.WriteLine();
//     }
// }

// double[,] result = Get2DArray(rows, columns); 
// Print2DArray(result);

// =================================================================================================
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите количество строк матрицы: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов матрицы: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// /// Создаем матрицу по заданным параметрам
// int[,] Get2DArray(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// /// Печатаем матрицу
// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// /// Ищем элемент в переданной матрице по заданным координатам х - строка, у - столбец
// void GetItem(int[,] matrix, int x, int y)
// {
//     if (x > matrix.GetLength(0) || y > matrix.GetLength(1))
//     {
//         Console.WriteLine("Элемент за пределами матрицы");
//     }
//     else
//     {
//         Console.WriteLine($"Искомый элемент найден: {matrix[x-1, y-1]}");  // Координаты выравниваю с привычным отсчетом от единицы, а не от 0
//     }
// }

// int[,] result = Get2DArray(rows, columns, 0, 10);
// Console.WriteLine("Исходный массив");
// Print2DArray(result);

// Console.Write("Введите № элемента по оси Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите № элемента по оси У: ");
// int y = Convert.ToInt32(Console.ReadLine());
// GetItem(result, x, y);

// =================================================================================================
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

/// Создаем матрицу по заданным параметрам
int[,] Get2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
/// Печатаем матрицу
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
/// Считаем сумму каждой колонки и печатаем среднее арифмитическое
void GetAverageColumns(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < columns; i++)
        {
            sum = sum + matrix[i, j];
        }
        Console.Write( Math.Round((sum / rows),2) + "\t");   // округляем для удобства
    }
}

int[,] result = Get2DArray(rows, columns, 0, 10);
Console.WriteLine("Исходный массив:");
Print2DArray(result);

Console.WriteLine("Среднее арифмитическое:");
GetAverageColumns(result);
