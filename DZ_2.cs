// int number = new Random().Next(10, 100); // Next (start, finish + 1)

// int firstDigit = number / 10;//Первая цифра числа: 78 -> 7

// int secondDigit = number % 10; //Вторая цифра числа: 78 -> 8

// int max = firstDigit; // Пусть максимум - первая цифра числа

// if (secondDigit > max ) // max = 5, secondDigit  = 10
// {
//     max = secondDigit;
// }
// Console.WriteLine("Исходное число: " + number);
// Console.WriteLine("Максимальное число: " + max);

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000); // Next (start, finish + 1)

// int firstDigit = number / 100;//Первая цифра числа: 78 -> 7

// int thirdDigit = number % 10; //Вторая цифра числа: 78 -> 8

// Console.WriteLine("Исходное число: " + number);
// Console.WriteLine("Полученное число: " + (firstDigit * 10 + thirdDigit)); // Console.WriteLine("Полученное число: " + firstDigit + thirdDigit);


// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int fistNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (fistNumber % secondNumber == 0) 
//     Console.Write("кратно");
// else
//     Console.Write("Остаток: " + (fistNumber % secondNumber)); 

// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (Number % 7 == 0 && Number % 23 == 0)
//     Console.Write("кратно");
// else
//     Console.Write("Не кратно");
// =========================================================================================
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secondDigit = (number % 100 - number % 10) / 10;
// Console.Write("Вторая цифра: " + secondDigit);

// =========================================================================================
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


//  Задачу решил для положительных чисел num
// int num, count, numDigit;                               
// Console.Write("Введите любое число: ");          // Int32: хранит целое число от -2147483648 до 2147483647
// num = Convert.ToInt32(Console.ReadLine());
// numDigit = NumberDigit(num);                    // Вызываем метод поиска разряда заданного числа num

// if (numDigit <= 2)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else
// {
//     num = (num / Convert.ToInt32(Math.Pow(10, numDigit - 3))) % 10;
//     Console.WriteLine($"Третья цифра введённого числа: {num}");
// }

// // Метод - возвращает разряд числа number
// int NumberDigit(int number)
// {
//     count = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }

// =========================================================================================
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 1 && number < 6)
//     Console.Write("будни");
// else if (number > 5 && number < 8)
//     Console.Write("выходные");
// else
//     Console.Write("ошибка ввода");