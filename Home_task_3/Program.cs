// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
// Вроде работает для любого целого числа
bool Pal(int num)
{
    bool nums = true;
    int middleNum = num;
    while (middleNum >= 10 || middleNum <= -10)
    {
        int rightNum = 0;
        rightNum = middleNum % 10;
        int leftNum = middleNum;
        int count = 1;
        while (leftNum >= 10 || leftNum <= -10)
        {
            leftNum = leftNum / 10;
            count = count * 10;
        }
        if (leftNum == rightNum)
        {
            nums = true;
            middleNum = middleNum % count / 10;
        }
        else
        {
            nums = false;
            middleNum = middleNum * 0;
        }
    }
    return nums;
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (Pal(num)) Console.WriteLine("Число является палиндромом!!! Ура!");
else Console.WriteLine("Число НЕ является палиндромом!!!Несудьба...");

// Намучался с этой задачей, оказалось в последней строке забыл "НЕ" дописать и прога всегда
// выдавала, что любое число палиндром))))

*/



// Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Dlina(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return Math.Round(result, 3);
}

Console.WriteLine("Координаты 1й точки(x,y,z): ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координаты 2й точки(x,y,z): ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками: {Dlina(x1, y1, z1, x2, y2, z2)}");

*/


// Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Kub(int num)
{
    if (num >= 1)
    {
        int i = 1;
        while (i <= num)
        {
            Console.WriteLine($"{i} в кубе = {i * i * i} ");
            i++;
        }
    }
    else
    {
        int i = 1;
        while (i >= num)
        {
            Console.WriteLine($"{i} в кубе = {i * i * i} ");
            i--;
        }
    }
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Кубы чисел от 1 до {num}: ");
Kub(num);
*/
