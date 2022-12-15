// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("let's compare two numbers");
Console.WriteLine("Input 2 numbers, first of them: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("and second please: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num2;
if (num1 > num2)
{
    max = num1;
    Console.WriteLine("max = " + max);
}
else
{
    if (num1 == num2)
    {
        Console.WriteLine("number one = number two, and max = " + max);
    }
    else
    {
        Console.WriteLine("max = " + max);
    }
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("let's find maximum of 3 numbers");
Console.WriteLine("Input 3 numbers, first of them: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("and second please: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("and third: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int count = 1;
if (num2 >= max)
{
    if (num2 > max)
    {
        max = num2;
    }
    else
    {
        count = count + 1;
    }
}
if (num3 >= max)
{
    if (num3 > max)
    {
        max = num3;
    }
    else
    {
        count = count + 1;
    }
}
Console.WriteLine("maximum " + count + " of it, and max = " + max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Determine an even number or odd");
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} четное!");
}
else
{
    Console.WriteLine($"Число {num} нечетное!");
}
*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Find all even numbers between 1 and your number");
Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int end = 1;
if (num > 1)
{
    count = 1;
    end = num;
}
else
{
    count = num;
    end = 1;
}
while (count <= end)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count += 1;
}
Console.WriteLine(".");
*/

