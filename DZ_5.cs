// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GetArray(int minValue, int maxValue, int count)
// {
//     int[] array = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// int[] resultArray = GetArray(100, 1000, 4);
// Console.WriteLine(String.Join("; ", resultArray));
// int countPositive = 0;
// int size = resultArray.Length;
// for (int i = 0; i < size; i++)
// {
//     if (resultArray[i] % 2 == 0)
//         countPositive++;
// }
// Console.WriteLine(countPositive);

//=============================================================================================
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] GetArray(int minValue, int maxValue, int count)
// {
//     int[] array = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// int[] resultArray = GetArray(-99, 99, 4);
// Console.WriteLine(String.Join("; ", resultArray));
// int sum = 0;
// int size = resultArray.Length;
// for (int i = 1; i < size; i = i + 2)
// {
//     sum = sum + resultArray[i];
// }
// Console.WriteLine(sum);

//=============================================================================================
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

// double[] GetArray(int count)
// {
//     double[] array = new double[count];
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().NextDouble();
//         array[i] = Math.Round(array[i], 2);         //округлил до сотых, для удобства проверки
//     }
//     return array;
// }

// double[] resultArray = GetArray(4);                 // количество элементов массива
// Console.WriteLine(String.Join("; ", resultArray));
// double diff = 0; 
// double min = resultArray[0]; double max = resultArray[0];
// int size = resultArray.Length;
// for (int i = 0; i < size; i++)
// {
//     if (resultArray[i] > max)
//         max = resultArray[i];
//     else if (resultArray[i] < min)
//         min = resultArray[i];
// }
// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Максимальное число: {max}");
// Console.WriteLine($"Разница чисел = {diff = max - min}");

//=============================================================================================
// Задача 37 со звездочкой, дополнительная: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int minValue, int maxValue, int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] resultArray = GetArray(0, 10, 9);
Console.WriteLine(String.Join("; ", resultArray));

int size = resultArray.Length;
int count = size / 2 + size % 2;

int[] tempArray = new int[count];

if (count % 2 != 0)
{
    for (int i = 0; i < count - 1; i++)
    {
        tempArray[i] = resultArray[i] * resultArray[size - i - 1];
    }
    tempArray[count - 1] = resultArray[count - 1];
}
else
{
    for (int i = 0; i < count; i++)
    {
        tempArray[i] = resultArray[i] * resultArray[size - i - 1];
    }
}

Console.WriteLine(String.Join("; ", tempArray));