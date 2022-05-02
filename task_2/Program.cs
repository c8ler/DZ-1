// Задача 1: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.Write("Введите число a: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int num2 = int.Parse(Console.ReadLine());
if(num1 > num2)
{
    Console.Write("max = ");
    Console.WriteLine(num1);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(num2);
}