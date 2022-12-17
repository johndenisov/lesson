//С# Генерация случайного числа с условиями диапазона.
//получить 1 цифру
// 2 цифру
//Сравнение
int N = new Random().Next(10, 99);
int firstDigit = N / 10;
int secondDigit = N % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}
