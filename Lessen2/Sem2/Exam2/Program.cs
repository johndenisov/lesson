// Напишие программу , которая принимает на вход два числа 
///и сообщает является ли второе число кратным первому.
// Если одно число кратно другому.


Console.WriteLine("Ввведите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите число ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    if(a % b == 0) //кратное
    {
        Console.WriteLine("Кратное ");
    }
    else
    {
        int result = a % b;
        Console.WriteLine("Некратное остаток равен " +  result);
    }
}
else
{
    if(b % a == 0)
    {
        Console.WriteLine("Кратное ");
    }
    else
    {
        int result = b % a;
        Console.WriteLine("Некратное остаток равен " +  result);
    }

} // можно решить, также через функцию
