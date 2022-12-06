//Напишите программу, которая на вход принимает число
 и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.WriteLine("Введите 3 числа:");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (number_2 > max)
{
    max = number_2;
}
if (number_3 > max)
{
    max = number_3;
}

Console.WriteLine("Наибольшее число: " + max);