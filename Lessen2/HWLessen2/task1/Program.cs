//Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введи трёхзначное число: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

string Number = Convert.ToString(threeDigitNumber);

if (Number.Length > 2)
    {
    Console.WriteLine("вторая цифра этого числа  " + Number[1]);
    }
else 
    {
    Console.WriteLine("Вы ввели не трехзначное число ");
    }

