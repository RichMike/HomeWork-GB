// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] UserArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Введите {0}-й элемент", i + 1);
//         array[i] = int.Parse(Console.ReadLine());
//     }
//     return array;
// }

// Console.WriteLine("Введите длину массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] userArr = UserArray(size);
// Console.WriteLine(String.Join("; ", userArr));

// int count = 0; 

// foreach (int item in userArr)
// {
//     if (item > 0)
//         count++;
// }
// Console.WriteLine($"Количество чисел больше 0: {count}");


// ========================================================================================================
// Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите b1: ");
// double b1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите к1: ");
// double k1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите b2: ");
// double b2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите к2: ");
// double k2 = int.Parse(Console.ReadLine()!);

// double x = (b2 - b1) / (k1 - k2);
// double y = k2 * x + b2;

// Console.WriteLine($"x={x}, y={y}");

// ========================================================================================================
// Задача 43 (ДОП, по желанию, на 5 нужно сделать 2 задачки): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string BinaryNumberSystem(int decimalNumber) 
{ 
    string binaryNumber = string.Empty; 
    int tempChastnoe = 2; 
    while (tempChastnoe > 0) 
    { 
        int ostatatok = decimalNumber % 2; 
        tempChastnoe = decimalNumber / 2; 
        binaryNumber = Convert.ToString(ostatatok) + binaryNumber; 
        decimalNumber = tempChastnoe; 
    } 
    return binaryNumber; 
} 
 
Console.WriteLine("Введите число для конвертации: "); 
int decimalNumber = int.Parse(Console.ReadLine()!); 
 
string res = BinaryNumberSystem(decimalNumber); 
Console.WriteLine(res);