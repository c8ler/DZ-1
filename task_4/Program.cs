// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine());
if(num1 > num2 & num1 > num3)
{
    Console.Write("max = ");
    Console.WriteLine(num1);
}
if(num2 > num1 & num2 > num3)
{
    Console.Write("max = ");
    Console.WriteLine(num2);
}
if(num3 > num1 & num3 > num2)
{
    Console.Write("max = ");
    Console.WriteLine(num3);
}