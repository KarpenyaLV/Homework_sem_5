﻿// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int numberN = int.Parse(Console.ReadLine());

// // Метод нахождения суммы натуральных элементов в промежутке от M до N
// void GapNumberSum (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     GapNumberSum(numberM, numberN, sum);
// }

// GapNumberSum(numberM, numberN, 0);

// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());

///Метод вычисления функции Аккермана:
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");
