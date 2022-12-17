//Задача 2: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");

int AnyNumber = Convert.ToInt32(Console.ReadLine());

string Number = Convert.ToString(AnyNumber);

if (Number.Length > 2)
{
    Console.WriteLine("Третья цифра этого числа: "  + Number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет, введите цифру еще раз. ");
}


