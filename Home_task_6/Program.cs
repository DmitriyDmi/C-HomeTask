//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int count = 0;
Console.WriteLine("Сколько чисел будем вводить:");
int len = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < len; i++)
{
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++;
}
Console.WriteLine($"Больше нуля {count} из них");
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
Console.WriteLine("для уравнений y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;

if (k1==k2) Console.WriteLine("Прямые не пересекаются");
else
{
    x = (b1 - b2) / (k2 - k1);
    y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения: ({x};{y})");
}

*/