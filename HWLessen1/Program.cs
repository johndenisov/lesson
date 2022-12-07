//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;

Console.WriteLine("Чётные числа от 1 до " + number);
while (i <= number)
{
    if (i % 2 != 1)
        {
        Console.Write(i + ", ");
        }
    i++;
}
//Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

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

