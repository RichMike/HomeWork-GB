// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число А: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите степень В: ");
// int stepen = int.Parse(Console.ReadLine()!);
// int result = number;

// if (number == 0)
//     Console.WriteLine("Ноль в любой степени равен 0");
// else
// {
//     if (stepen == 0)
//         Console.WriteLine($"{number} в степни {stepen} = 1");
//     else if (stepen > 0)
//     {
//         for (int i = 1; i < stepen; i++)
//         {
//             result = result * number;
//             // Console.WriteLine(result);  // проверка промежуточных результатов
//         }
//         Console.WriteLine($"{number} в степни {stepen} = {result}");
//     }
//     else
//     {
//         int negativeStepen = stepen * (-1);
//         for (int i = 1; i < negativeStepen; i++)
//         {
//             result = result * number;
//             // Console.WriteLine(result);  // проверка промежуточных результатов
//         }
//         Console.WriteLine($"{number} в степни {stepen} = {(1 / (double)result)}");
//     }
// }


// ======================================================================================================================
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Метод - возвращает разряд числа number
// int NumberDigit(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int sumDigit = 0;

// if (number >= 0 && number < 10)
// {
//     Console.WriteLine($"Сумма = {number}");
// }
// else if (number > 9)
// {
//     int numDigit = NumberDigit(number);
//     int digit;
//     for (int i = 1; i <= numDigit; i++)
//     {
//         digit = (number / Convert.ToInt32(Math.Pow(10, numDigit - i))) % 10;
//         sumDigit = sumDigit + digit;
//     }
//     Console.WriteLine($"sumDigit = {sumDigit}");
// }
// else
// {
//     number = number * (-1);
//     int numDigit = NumberDigit(number);
//     int digit;
//     for (int i = 1; i <= numDigit; i++)
//     {
//         digit = (number / Convert.ToInt32(Math.Pow(10, numDigit - i))) % 10;
//         sumDigit = sumDigit + digit;
//     }
//     Console.WriteLine($"sumDigit = {sumDigit}");
// }


// ======================================================================================================================
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// //Метод создаёт и заполняет массив случайными числами в указанном диапазоне
// int[] GetArray(int size, int leftRange, int rightRange)
//  // size - размер массива, leftRange - левая граница, rightRange - правая граница
// {
//     int[] array = new int[size]; //Массив на size элементов, заполненных нулями
//     for (int i = 0; i < size; i++) // size = array.Length
//     {
//         array[i] = new Random().Next(leftRange, rightRange + 1);
//     }
//     return array;
// }

// Console.WriteLine("Введите длину массива: ");
// int size = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите левую границу диапазона: ");
// int left = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите правую границу диапазона: ");
// int right = int.Parse(Console.ReadLine()!);

// // Вызов метода
// int[] resultArray = GetArray(size, left, right);
// Console.WriteLine($"Итоговый массив: [{String.Join("; ", resultArray)}]");