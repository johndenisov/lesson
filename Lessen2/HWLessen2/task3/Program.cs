﻿//Задача 3: Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Введите число ");

int Number = Convert.ToInt32(Console.ReadLine());

if ((Number % 7 == 0) && (Number % 23 == 0))
    {
       Console.WriteLine("Данное число:  " +  Number  + " одновременно кратно 7 и 23"); 
    }
else
    {
    Console.WriteLine("Данное число одновременно некратно 7 и 23 ");

    }