// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNumber(int num)
{
    int findSecond = Math.Abs(num / 10) % 10;
    return findSecond;
}
Console.WriteLine("Input number bitween 100 and 999:");
int num = Convert.ToInt32(Console.ReadLine());
if (num>999 || num<100)
{
    Console.WriteLine("It's not correct number, but answer is: ");
}
Console.WriteLine("second number is " + SecondNumber(num));
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
// Для 3й цифры слева
int Third(int num)
{
    while(num/1000>=1 || num/1000<=-1)
    {
        num = num / 10;
    }
    if (num>0)
    {
        int third = num % 10;
        return third;
    }
    else
    {
        int third = -1 * num % 10;
        return third;
    }
}

// Для 3й цифры справа
// int Third(int num)
// {
//     int third = Math.Abs(num / 100) % 10;
//     return third;
// }

Console.WriteLine("Input number :");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 && num > -100)
{
    Console.WriteLine("third number is NULL");
}
else
{
    int thirdNum = Third(num);
    Console.WriteLine("third number is " + thirdNum);
}
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool WeekEnd(int dayNum)
{
    if (dayNum >= 6)
        return true;
    else
    {
        return false;
    }
}

link1:
Console.WriteLine("Input number day of week:");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum < 1 || dayNum > 7)
{
    Console.WriteLine("Wrong day number, try again");
    goto link1;
}
else
{
    if (WeekEnd(dayNum))
        Console.WriteLine("It's weekend day");
    else
    {
        Console.WriteLine("It's NOT weekend day");
    }
}

*/