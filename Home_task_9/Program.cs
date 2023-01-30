// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

void ShowNums(int num)
{
    if (num == 1) Console.WriteLine(num + " ");
    else Console.Write(num + ", ");
    if (num > 1) ShowNums(num - 1);
}

ShowNums(num);
*/

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
Console.Write("Введите число N:");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M:");
int numM = Convert.ToInt32(Console.ReadLine());

int GetSum(int N, int M)
{
    if (N > M) return N + GetSum(N - 1, M);
    if (N < M) return M + GetSum(N, M - 1);
    else return N;
}

Console.WriteLine(GetSum(numN, numM));
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return ack(m - 1, 1);
    else return ack(m - 1, ack(m, n - 1));
}

Console.Write("Введите число M:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ack(numM, numN));
*/