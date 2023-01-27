// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRows(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        int count = 0;

        for (int k = 0; k < massiv.GetLength(1); k++)
        {
            for (int j = 1; j < massiv.GetLength(1); j++)
            {
                if (massiv[i, j] > massiv[i, j - 1])
                {
                    int temp = massiv[i, j - 1];
                    massiv[i, j - 1] = massiv[i, j];
                    massiv[i, j] = temp;
                    count++;
                }
            }
            if (count == 0) break;
        }
    }
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

SortRows(myMassiv);

ShowMassiv(myMassiv);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

int MinSumRow(int[,] massiv)
{
    int minSum = 0;
    int minSumIndex = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < massiv.GetLength(1); j++)
            sum = sum + massiv[i,j];
        if (i==0) minSum = sum;
        if (sum < minSum)
        {
            minSum = sum;
            minSumIndex = i;
        }
    }
    return minSumIndex;
}

int[,] myMassiv = CreateRandomNewMassiv();

ShowMassiv(myMassiv);

Console.WriteLine($"Минимальная сумма элементов в: {MinSumRow(myMassiv)+1} строке");
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultiMatrix(int[,] massiv1, int[,] massiv2)
{
    int[,] massiv = new int[massiv1.GetLength(0), massiv2.GetLength(1)];

    for (int i = 0; i < massiv.GetLength(0); i++)
        for (int j = 0; j < massiv.GetLength(1); j++)
            for (int k = 0; k < massiv1.GetLength(1); k++)
            {
                massiv[i, j] = massiv[i, j] + massiv1[i, k] * massiv2[k, j];
            }
    return massiv;
}

Console.WriteLine("Параметры первой матрицы:");
int[,] matrix1 = CreateRandomNewMassiv();
Console.WriteLine();
Console.WriteLine("Параметры второй матрицы:");
int[,] matrix2 = CreateRandomNewMassiv();

Console.WriteLine("Матрица 1:");
ShowMassiv(matrix1);
Console.WriteLine("Матрица 2:");
ShowMassiv(matrix2);

if (matrix1.GetLength(1) != matrix2.GetLength(0))
    Console.WriteLine("матрицы перемножать нельзя");
else
{
    Console.WriteLine("Результирующая матрица:");
    ShowMassiv(MultiMatrix(matrix1, matrix2));
}
*/


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


/*
Console.Write("Введите ограничение количеста переборов для элементов:");
int stopRecurs = Convert.ToInt32(Console.ReadLine());
int stopCount = 0;

int[,,] CreateRandomNewMassiv()
{
    Console.Write("Введите количество строк:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество слоев:");
    int sloy = Convert.ToInt32(Console.ReadLine());

    if (row * columns * sloy > 89)
    {
        Console.WriteLine("Некорректный размер массива, попробуйте заного:");
        return CreateRandomNewMassiv();
    }
    int[,,] massiv = new int[row, columns, sloy];
    for (int k = 0; k < sloy; k++)
        for (int i = 0; i < row; i++)
            for (int j = 0; j < columns; j++)
            {
                stopCount = 0;
                massiv[i, j, k] = CreateElemet(massiv, stopCount);
            }
    return massiv;
}

void ShowMassiv(int[,,] massiv)
{
    for (int k = 0; k < massiv.GetLength(2); k++)
    {
        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
                Console.Write($"{massiv[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

bool UniqueElement(int elemetn, int[,,] massiv)
{
    for (int k = 0; k < massiv.GetLength(2); k++)
        for (int i = 0; i < massiv.GetLength(0); i++)
            for (int j = 0; j < massiv.GetLength(1); j++)
                if (elemetn == massiv[i, j, k]) return false;
    return true;
}

int CreateElemet(int[,,] massiv, int stopCount)
{
    int newElemet = new Random().Next(10, 100);
    if (UniqueElement(newElemet, massiv)) return newElemet;
    else
    {
        if (stopCount > stopRecurs)
        {
            Console.WriteLine("Ошибка заполнения");
            return 100;
        }
        stopCount++;
        newElemet = CreateElemet(massiv, stopCount);
    }
    return newElemet;
}

int[,,] matrix = CreateRandomNewMassiv();

ShowMassiv(matrix);
*/
// Сделал двойную проверку на количество элементов в CreateRandomNewMassiv
// и в CreateElemet проверка от зацикливания рекрсии 



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


/*
int[,] CreateRandomNewMassiv()
{
    Console.Write("Введите количество строк:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());


    int[,] massiv = new int[row, columns];

    int count = 1;
    int indexRow = 0;
    int indexColomn = 0;
    for (int i = 0; i < row * columns; i++)
    {
        if (indexRow < massiv.GetLength(0) && indexColomn < massiv.GetLength(1) && massiv[indexRow, indexColomn] == 0)
        {
            massiv[indexRow, indexColomn] = count;
            count++;
            if (indexColomn + 1 < massiv.GetLength(1) 
            && massiv[indexRow, indexColomn + 1] == 0 
            && (indexRow == 0 || massiv[indexRow - 1, indexColomn] != 0)) indexColomn++;
            else if (indexRow + 1 < massiv.GetLength(0) 
            && massiv[indexRow + 1, indexColomn] == 0) indexRow++;
            else if (indexColomn > 0 
            && massiv[indexRow, indexColomn - 1] == 0) indexColomn--;
            else if (indexRow > 0 
            && massiv[indexRow - 1, indexColomn] == 0) indexRow--;
        }
    }

    return massiv;
}

void ShowMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
            Console.Write("{0,5}", massiv[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myMassiv = CreateRandomNewMassiv();

ShowMassiv(myMassiv);
*/