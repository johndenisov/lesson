//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите первое число: ");

int number_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int number_B = Convert.ToInt32(Console.ReadLine());

if (number_A > number_B)
{
    Console.WriteLine("Первое число: " + number_A + " больше, чем второе: " + number_B);
}
else
{

    Console.WriteLine("Второе число: " + number_B + " больше, чем первое: " + number_A);
}