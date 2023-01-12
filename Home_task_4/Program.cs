//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*
int ChtoToSchetem(int num, int st)
{
    int itog = 1;
    for(int i=0; i!=st;i++) //не знаю куда тут еще можно цикл запихнуть
    {
        itog = itog*num;
    }
    return itog;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
int step = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ChtoToSchetem(number, step));
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*
int Summa(int num)
{
    int sum = 0;
    while (num!=0)
    {
        sum = sum + num%10;
        num = num/10;
    }
    return sum;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(number));

*/


//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*
int[] CreateMyArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i}й элемент массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Задайте длину массива:");
int size = Convert.ToInt32(Console.ReadLine());

//int[] myArray = CreateMyArray(size); // и без этого работает =)
ShowArray(CreateMyArray(size));

*/

//Бонус:
// В задаче из семинара про длину числа прекрасно работает оператор цикла FOR =))
/*
int Len(int num)
{
    int count = 0;
    for (int i = num; i != 0; count++)
    {
        i = i / 10;
    }
    return count;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Len(number));
*/