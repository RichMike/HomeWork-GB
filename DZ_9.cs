// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// Console.WriteLine("Write firstNumber: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Write secondNumber: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// string IntervalNumber(int firstDigit, int secondDigit)
// {
//     if (firstDigit > secondDigit)
//     {
//         int temp = firstDigit;
//         firstDigit = secondDigit;
//         secondDigit = temp;
//     }
//     if (firstDigit == secondDigit) return firstDigit.ToString();
//     return Convert.ToString(firstDigit + ", " + IntervalNumber(firstDigit + 1, secondDigit));
// }

// Console.WriteLine(IntervalNumber (firstNumber, secondNumber));

//==================================================================================================
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Write firstNumber: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Write secondNumber: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int SumIntervalDigits(int startDigit, int lastDigit)
// {
//         if (startDigit > lastDigit)
//         {
//                 int temp = startDigit;
//                 startDigit = lastDigit;
//                 lastDigit= temp;
//         }
//         if (startDigit == lastDigit) return startDigit;
//         return startDigit + SumIntervalDigits(startDigit + 1, lastDigit);
// }
// Console.WriteLine($"Сумма натуральных элементов между числами {firstNumber} и {secondNumber} равна: {SumIntervalDigits(firstNumber, secondNumber)}");

//==================================================================================================
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

// Console.WriteLine("Write firstNumber: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Write secondNumber: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber < 0 || secondNumber < 0)
// {
//     Console.WriteLine("Введено отрицательное значение");
//     return;
// }

// double AkkermanFunnction(double m, double n)
// {
//     if (m == 0) return n + 1;
//     else
//     {
//         if (m != 0 && n == 0) return AkkermanFunnction(m - 1, 1);
//         else return AkkermanFunnction(m - 1, AkkermanFunnction(m, n - 1));
//     }
// }

// double A = AkkermanFunnction(firstNumber, secondNumber);
// Console.WriteLine($"Значение функции аккермана: Akkerman ({firstNumber}, {secondNumber}) = {A}");