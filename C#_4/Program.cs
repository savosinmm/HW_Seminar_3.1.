﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine( "Введите целое число");
int N = Convert.ToInt32( Console.ReadLine ( ));
int i = 1;
if (N <= 0)
{
    Console.WriteLine("Запустите программу заново и введите положительное число");
}
else
    Console.WriteLine( $"Четные числа от 1 до {N}");
while (i <= N)
{
if (i % 2 == 0)

    Console.WriteLine($"{i}");
    i = i + 1;
}
