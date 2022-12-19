// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.WriteLine("Input number bitween 100 and 999:");
int num = Convert.ToInt32(Console.ReadLine());

int findSecond = Math.Abs(num / 10) % 10;
Console.WriteLine("second number is " + findSecond);
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.WriteLine("Input number :");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 && num > -100)
{
    Console.WriteLine("third number is NULL");
}
else
{
    int third = Math.Abs(num / 100) % 10;
    Console.WriteLine("third number is " + third);
}
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
link1:
Console.WriteLine("Input number dey of week:");
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum < 1)
{
    Console.WriteLine("Wrong day number, try again");
    goto link1;
}
else if (dayNum > 7)
{
    Console.WriteLine("Wrong day number, try again");
    goto link1;
}
else
{
    if (dayNum >= 6)
        Console.WriteLine("It's weekend day");
    else
    {
        Console.WriteLine("It's not weekend day");
    }
}
*/