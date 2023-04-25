/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

double[,] CreateRandArr(int rows, int cols)
{
    double[,] buf = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            buf[i, j] = Math.Round(Convert.ToDouble(rand.Next(0, 101) - 50) + rand.NextDouble(), 1);
    }
    return buf;
}

void PrintComplexArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}
void Ex1()
{
    int a, b;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());

    double[,] temp = CreateRandArr(a, b);
    PrintComplexArr(temp);
}
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет
*/

void FindElem(double[,] arr, int x, int y)
{
    bool flag = true;
    if ((arr.GetLength(0) - x <= 0) || (arr.GetLength(1) - y <= 0)) Console.WriteLine("Wring cords");
    else Console.WriteLine($"{arr[x, y]}");
}
void Ex2()
{
    int x1, y1;
    int a, b;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    x1 = int.Parse(Console.ReadLine());
    y1 = int.Parse(Console.ReadLine());
    double[,] temp = CreateRandArr(a, b);
    FindElem(temp, x1, y1);
}
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] CreateRandArrInt(int rows, int cols)
{
    int[,] buf = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            buf[i, j] = rand.Next(0, 10);
    }
    return buf;
}

double[] FindMid(int[,] arr)
{
    int bufSum = 0;
    double[] bufMid = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            bufSum += arr[i, j];
        bufMid[i] = Math.Round(Convert.ToDouble(bufSum) / Convert.ToDouble(arr.GetLength(0)),3);
        bufSum = 0;
    }
    return bufMid;
}
void PrintComplexArrInt(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

void PrintSinpleArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
void Ex3()
{
    int x2, y2;
    x2 = int.Parse(Console.ReadLine());
    y2 = int.Parse(Console.ReadLine());
    int[,] tempInt = CreateRandArrInt(x2, y2);
    double[] result = FindMid(tempInt);
    PrintComplexArrInt(tempInt);
    PrintSinpleArr(result);
}
Ex1();
Ex2();
Ex3();