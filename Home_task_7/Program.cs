// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double[,] CreateRandomNewMassiv(int toRound)
{
    Console.Write("Введите количество строк:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимум:");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимум:");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] massiv = new double[row, columns];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < columns; j++)
            massiv[i, j] = new Random().Next(minValue, maxValue)
            + Math.Round(new Random().NextDouble(), toRound);

    return massiv;
}

void ShowMassiv(double[,] massiv, int toRound)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
            Console.Write(Math.Round(massiv[i, j], toRound) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите до каких округляем:");
int toRound = Convert.ToInt32(Console.ReadLine());

double[,] myMassiv = CreateRandomNewMassiv(toRound);

ShowMassiv(myMassiv, toRound);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> числа с такими индексами в массиве нет

/*
int[,] CreateRandomNewMassiv()
{
    Console.Write("Введите количество строк:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимум:");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимум:");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] massiv = new int[row, columns];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < columns; j++)
            massiv[i, j] = new Random().Next(minValue, maxValue + 1);

    return massiv;
}

void ShowElement(int[,] myMassiv, int indexRow, int indexColomn)
{
    if (indexRow < myMassiv.GetLength(0) && indexColomn < myMassiv.GetLength(1))
        Console.WriteLine($"Элемент с индексами ({indexRow},{indexColomn}) равен {myMassiv[indexRow,indexColomn]}");
    else Console.WriteLine($"{indexRow} {indexColomn} -> числа с такими индексами в массиве нет");
}

void ShowMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
            Console.Write(massiv[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myMassiv = CreateRandomNewMassiv();

ShowMassiv(myMassiv);

Console.Write("Введите индекс строки искомого элемента:");
int indexRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца искомого элемента:");
int indexColomn = Convert.ToInt32(Console.ReadLine());

ShowElement(myMassiv, indexRow, indexColomn);
*/


//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


/*
int[,] CreateRandomNewMassiv()
{
    Console.Write("Введите количество строк:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимум:");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимум:");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] massiv = new int[row, columns];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < columns; j++)
            massiv[i, j] = new Random().Next(minValue, maxValue + 1);

    return massiv;
}

void ShowMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
            Console.Write(massiv[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] CreateArray(int[,] massiv)
{
    double[] array = new double[massiv.GetLength(1)];

    for (int i = 0; i < massiv.GetLength(1); i++)
    {
        for (int j = 0; j < massiv.GetLength(0); j++)
            array[i] = array[i] + massiv[j, i];
        array[i] = Math.Round(array[i] / massiv.GetLength(0), 1);
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.WriteLine(array[i] + ".");
        Console.Write(array[i] + "; ");
    }
}

int[,] myMassiv = CreateRandomNewMassiv();

ShowMassiv(myMassiv);

Console.Write($"Среднее арифметическое каждого столбца: ");
ShowArray(CreateArray(myMassiv));
*/
