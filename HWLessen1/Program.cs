﻿//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");

int number = Convert.ToInt32(Console.ReadLine());

if (number %  2 == 1)
{
    Console.WriteLine("Число " + number + " : нечетное");
}
else
{
    Console.WriteLine("Число " + number + " : четное");
}