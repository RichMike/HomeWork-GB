// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// /// Метод выводит матрицу на экран
// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам 
//         {
//             Console.Write(matrix[i, j] + "\t"); // "\t" = Tab   
//         }
//         Console.WriteLine();
//     }
// }

// /// Метод создает матрицу заданных размеров с рандомными элементами
// int[,] CreateRandomMatrix(int rows, int columns)
// {
//     int[,] array = new int[rows, columns]; // 2 строчки, 2 столбца
//     for (int i = 0; i < rows * columns; i++)
//     {
//         array[i / columns, i % columns] = new Random().Next(11);
//     }
//     return array;
// }

// /// Метод сортирует элементы по убыванию в каждой строке
// int[,] SortArrayLow(int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns - 1; j++)
//         {
//             for (int k = 0; k < columns - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return matrix;
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = CreateRandomMatrix(rows, columns);
// Print2DArray(result);
// Console.WriteLine();

// result = SortArrayLow(result);
// Print2DArray(result);

// =======================================================================
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// /// Метод создает матрицу заданных размеров с рандомными элементами
// int[,] CreateRandomMatrix(int rows, int columns)
// {
//     int[,] array = new int[rows, columns]; // 2 строчки, 2 столбца
//     for (int i = 0; i < rows * columns; i++)
//     {
//         array[i / columns, i % columns] = new Random().Next(11);
//     }
//     return array;
// }

// /// Метод выводит матрицу на экран
// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам 
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам 
//         {
//             Console.Write(matrix[i, j] + "\t"); // "\t" = Tab   
//         }
//         Console.WriteLine();
//     }
// }

// /// Метод выводит номер строки с наименьшей суммой элементов
// void FindMinArray(int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     int temp = Int32.MaxValue;
//     int numberStr = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < columns; j++)
//         {
//             sum += matrix[i,j];
//         }
//         if (temp > sum)
//         {
//             temp = sum;
//             numberStr = i;
//         }
//     }
//     Console.Write($"Минимальная сумма в строке: {numberStr + 1}");
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = CreateRandomMatrix(rows, columns);
// Print2DArray(result);
// Console.WriteLine();

// FindMinArray(result);


// =======================================================================
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] GetMatrix(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] matrix = new int[rows, colums];
//     int sizeRows = matrix.GetLength(0);
//     int sizeColums = matrix.GetLength(1);
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] inputMatrix)
// {
//     int sizeRows = inputMatrix.GetLength(0);
//     int sizeColums = inputMatrix.GetLength(1);
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             Console.Write($"{inputMatrix[i, j]}\t");
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
// }

// int[,] MultipliMatrix(int[,] matrixFirst, int[,] matrixSecond)
// {
//     int firstRows = matrixFirst.GetLength(0); // i число строк результирующей матрицы
//     int firstColums = matrixFirst.GetLength(1); // n firstColums == secondRows обязательное условие
//     int secondRows = matrixSecond.GetLength(0); // n firstColums == secondRows обязательное условие      
//     int secondColums = matrixSecond.GetLength(1); // число столбцов результирующей матрицы
//     int[,] multipliMatrix = new int[firstRows, secondColums];

//     for (int i = 0; i < firstRows; i++)
//     {
//         for (int j = 0; j < secondColums; j++)
//         {
//             int scalarMultiplier = 0;
//             int scalarSum = 0;
//             for (int n = 0; n < firstColums; n++)
//             {
//                 scalarMultiplier = matrixFirst[i, n] * matrixSecond[n, j];
//                 scalarSum += scalarMultiplier;
//             }
//             multipliMatrix[i, j] = scalarSum;
//         }
//     }
//     return multipliMatrix;
// }

// Console.WriteLine("write count rows: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("write count colums: ");
// int colums = int.Parse(Console.ReadLine()!);

// Console.WriteLine("write count secondRows: ");
// int secondRows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("write count secondColums: ");
// int secondColums = int.Parse(Console.ReadLine()!);

// Console.WriteLine();

// if (colums != secondRows)
// {
//     Console.WriteLine("Error: Умножение не возможно!");
//     return;
// }

// int[,] matrixFirst = GetMatrix(rows, colums, 1, 5);
// PrintMatrix(matrixFirst);

// Console.WriteLine();

// int[,] matrixSecond = GetMatrix(secondRows, secondColums, 1, 5);
// PrintMatrix(matrixSecond);

// Console.WriteLine();

// int[,] multipliMatrix = MultipliMatrix(matrixFirst, matrixSecond);
// PrintMatrix(multipliMatrix);


// =======================================================================
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Get3DArray(int rows, int colums, int depth, int minValue, int maxValue)
// {
//     int[,,] array3d = new int[rows, colums, depth];
//     int sizeRows = array3d.GetLength(0);
//     int sizeColums = array3d.GetLength(1);
//     int sizeDepth = array3d.GetLength(2);

//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             for (int k = 0; k < sizeDepth; k++)
//             {
//                 if (array3d[i, j, k] < maxValue)
//                 {
//                     array3d[i, j, k] = minValue;
//                     minValue++;
//                 }
//                 else break;
//             }
//         }
//     }
//     return array3d;
// }

// void Print3DArray(int[,,] input3DArray)
// {
//     int sizeRows = input3DArray.GetLength(0);
//     int sizeColums = input3DArray.GetLength(1);
//     int sizeDepth = input3DArray.GetLength(2);
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             for (int k = 0; k < sizeDepth; k++)
//             {
//                 Console.WriteLine($"{input3DArray[i, j, k]}\t ({i}, {j}, {k})\t");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("write count rows: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("write count colums: ");
// int colums = int.Parse(Console.ReadLine()!);

// Console.WriteLine("write count depth: ");
// int depth = int.Parse(Console.ReadLine()!);

// int[,,] input3DArray = Get3DArray(rows, colums, depth, 10, 99);

// Print3DArray(input3DArray);
// Console.WriteLine();

// =======================================================================
// Задача 62 (дополнительная). Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] GetMatrix(int rows, int colums)
// {
//     int[,] matrix = new int[rows, colums];
//     int sizeRows = matrix.GetLength(0);
//     int sizeColums = matrix.GetLength(1);
//     int CountItems = sizeRows * sizeColums;
//     int number = 1; // заполнение клеток
//     int i = 0;
//     int j = -1;
//     int driveI = 0; // перемещение по строкам (-1; 0; 1) (вверх; без перемещения; вниз)
//     int driveJ = 1; // перемещение по столбцам (-1; 0; 1) (влево; без перемещения; вправо)
//     while (number <= CountItems)
//     {
//         if (i + driveI >= 0 && i + driveI < sizeRows && j + driveJ >= 0 && j + driveJ < sizeColums && matrix[i + driveI, j + driveJ] == 0)
//         {
//             i += driveI;
//             j += driveJ;
//             matrix[i, j] = number;
//             number++;
//         }
//         else
//         {
//             if (driveJ == 1)
//             {
//                 driveJ = 0;
//                 driveI = 1;
//             }
//             else if (driveI == 1)
//             {
//                 driveI = 0;
//                 driveJ = -1;
//             }
//             else if (driveJ == -1)
//             {
//                 driveJ = 0;
//                 driveI = -1;
//             }
//             else if (driveI == -1)
//             {
//                 driveI = 0;
//                 driveJ = 1;
//             }
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] inputMatrix)
// {
//     int sizeRows = inputMatrix.GetLength(0);
//     int sizeColums = inputMatrix.GetLength(1);
//     for (int i = 0; i < sizeRows; i++)
//     {
//         for (int j = 0; j < sizeColums; j++)
//         {
//             Console.Write($"{inputMatrix[i, j]}\t");
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
// }

// // размер матрицы заранее прописал для удобного теста
// int rows = 9;
// int colums = 3;
// int[,] matrix = GetMatrix(rows, colums);

// PrintMatrix(matrix);