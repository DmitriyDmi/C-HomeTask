//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}

int Counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива:");
int len = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(len);
ShowArray(newArray);
Console.WriteLine(Counter(newArray));
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
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

int Summa(int[] array)
{
    int sum = 0;
    for(int i=1; i<array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.WriteLine("Введите длину массива:");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите низ массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верх массива:");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(len, min, max);
ShowArray(newArray);
Console.WriteLine(Summa(newArray));
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
double[] CreateRandomArray(int size, int min, int max, int toRound)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        // array[i] = Math.Round(new Random().NextDouble()*(max-min)+min, toRound);
        array[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), toRound);
        // или 1 генерация и 4 арефметич.действия, или 2 генерации и 1 действие. Не знаю что оптимальнее
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindMinMaxDelta(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i<array.Length; i++)
    {
        if(array[i]>max) max = array[i];
        else if(array[i]<min) min = array[i];
    }
    return max-min;
}

Console.WriteLine("Введите длину массива:");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите низ массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верх массива:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("До каких знаков округляем:");
int round = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(len, min, max, round);
ShowArray(myArray);
Console.WriteLine(Math.Round(FindMinMaxDelta(myArray),round));
*/