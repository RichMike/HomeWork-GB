// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int number = 12321; // промежуточная проверка

// System.Console.WriteLine("Введите 5-ти значное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int a1 = number % 10;
// int a2 = number / 10 % 10;
// int a3 = number / 100 % 10;
// int a4 = number / 1000 % 10;
// int a5 = number / 10000;
// int reverseNumber = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
// System.Console.WriteLine($"Обратное число: {reverseNumber}");

// if (number == reverseNumber)
//     System.Console.WriteLine("Полиндром");
// else System.Console.WriteLine("Не полиндром");

//==================================================================================

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Math.Sqrt(число) => Math.Sqrt(25) => 5
// Math.Pow (2, 3) => 8 = 2 * 2 * 2
// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); // Math.Pow(число, степень)
// // Math.Round(число, количество знаков) 
// Console.WriteLine("Расстояние между 2 точками: " + Math.Round(d));
// A (3,6); B (2,1) -> 5,09

//==================================================================================

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= number; i++)
// {
//     int sqrNumber = i * i * i;
//     Console.Write(sqrNumber + " ");
// }