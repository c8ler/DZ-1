﻿// Задача 4: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 2;
while (i < N + 1)
{
    Console.Write(i);
    i += 2;
    if(i < N + 1)
    {
        Console.Write(", ");
    }
}