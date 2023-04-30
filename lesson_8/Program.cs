/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateRandArrInt(int rows, int cols)
{
    int[,] buf = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            buf[i, j] = rand.Next(1, 11);
    }
    return buf;
}

void PrintComplexArrInt(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {
            if (arr[i,j] < 10) Console.Write(" ");
            Console.Write($"{arr[i, j]} ");
            }
        Console.WriteLine();
    }
}

int[,] SortRaws(int[,] arr)
{
    int swap;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                for(int k = j; k < arr.GetLength(1); k++)
                    if (arr[i,k] > arr[i,j])
                        {
                            swap = arr[i,j];
                            arr[i,j] = arr[i,k];
                            arr[i,k] = swap;
                        }
            }
    }
    return arr;
}

void Ex1()
{
    int x2, y2;
    x2 = int.Parse(Console.ReadLine());
    y2 = int.Parse(Console.ReadLine());
    int[,] tempInt = CreateRandArrInt(x2, y2);
    PrintComplexArrInt(tempInt);
    tempInt = SortRaws(tempInt);
    Console.WriteLine();
    PrintComplexArrInt(tempInt);
}

//Ex1();

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int SearchLowCount(int[,] arr)
{
    int sumIndex = 0;
    int currentSumMin = 0;
    int temp = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
            currentSumMin += arr[0,j];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            temp += arr[i,j];
        if (temp < currentSumMin) 
            {
                currentSumMin = temp;
                sumIndex = i;
            }
        temp = 0;
    }
    return sumIndex;
}

void Ex2()
{
    int x2, y2;
    x2 = int.Parse(Console.ReadLine());
    y2 = int.Parse(Console.ReadLine());
    int[,] tempInt = CreateRandArrInt(x2, y2);
    PrintComplexArrInt(tempInt);
    Console.WriteLine(SearchLowCount(tempInt));
}

//Ex2();

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

bool ValidateMatrixs(int[,] a, int[,] b)
{
    bool flag = true;
    if (a.GetLength(0) != b.GetLength(1)) flag = false;
    return flag;
}
int[,] MultMatrix(int[,] a, int[,] b)
{
    int[,] result = new int[a.GetLength(1),b.GetLength(0)];
    Console.WriteLine(a.GetLength(1));
    Console.WriteLine(b.GetLength(0));
    for (int i = 0; i < a.GetLength(1); i++)
        for (int j = 0; j < b.GetLength(0); j++)
            for (int k = 0; k < a.GetLength(0); k++)
                result[i,j] += a[i,k] * b[k,j];
    return result;
}

void Ex3()
{
    int x2, y2;
    x2 = int.Parse(Console.ReadLine());
    y2 = int.Parse(Console.ReadLine());
    int[,] tempIntA = CreateRandArrInt(x2, y2);
    x2 = int.Parse(Console.ReadLine());
    y2 = int.Parse(Console.ReadLine());
    int[,] tempIntB = CreateRandArrInt(x2, y2);
    PrintComplexArrInt(tempIntA);
    Console.WriteLine();
    PrintComplexArrInt(tempIntB);
    if (!ValidateMatrixs(tempIntA,tempIntB))
     {
        Console.WriteLine("You can't mul this matrix");
        return;
     }
    int[,] muledArr = MultMatrix(tempIntA,tempIntB);
    PrintComplexArrInt(muledArr);
}

//Ex3();
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

bool ValidateUniqElem(int[,,] arr,int curElem)
{
    bool flag = true;
    foreach(int elem in arr)
        if (elem == curElem) flag = false;
    return flag;
}

int[,,] CreateUniqIntArr(int x, int y,int z)
{
    int[,,] result = new int[x,y,z];
    Random rand = new Random();
    int tempElem = rand.Next(10,100);
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
                {
                while (!ValidateUniqElem(result,tempElem))
                {
                    //Console.WriteLine(tempElem);
                    //Console.WriteLine(ValidateUniqElem(result,tempElem));
                    tempElem = rand.Next(10,100);
                }
                result[i,j,k] = tempElem;
                }
    return result;
}

void Print3demenArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
                Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
}

void Ex4()
{
    int x2, y2, z2;
    x2 = int.Parse(Console.ReadLine());
    y2 = int.Parse(Console.ReadLine());
    z2 = int.Parse(Console.ReadLine());
    int[,,] tempArr = CreateUniqIntArr(x2,y2,z2);
    Print3demenArr(tempArr);
}

//Ex4();

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] CreateSpiralArr(int len)
{
    int[,] result = new int[len,len];
    int endpoint = len*len;
    len--; // длина текущего колена спирали
    int cursor = 0; //Счетчик, который записывается в позициию в спирали
    int i = 0;
    int j = 0;
    int cornerCounter = 1; //Указатель поворотов 1 - верхнее ребро спирали, 2 - правое ребро спирали, 3 - нижнее, 4 - левое
    int loolCounter = 0; //Указатель завершения петли, если мы заполнили 3 ребра, то указатель должен поменяться 
    while(cursor < endpoint) //Условие по колличеству элементов, закончит, как достигнем потолка счетчика
    {
        Console.WriteLine($"i= {i}, j= {j}, lc= {loolCounter}, cc= {cornerCounter}, c= {cursor}");//Для целей отладки
        result[i,j] = cursor;
        cursor++;
        switch (cornerCounter)
        {
            case 1:
            // Проверяем Х на достижение своего угла спирали при движеннии вправо
                if (i < len - loolCounter)
                    i++; //Движемся вправо
                else
                    {
                        cornerCounter = 2;
                    }
                break;
            case 2:
                if (j < len - loolCounter)
                    j++; //Движемся вниз
                else
                    {
                        cornerCounter = 3;
                    }
                break;
            case 3:
                if (i > loolCounter)
                    i--; //Движемся влево до начала границы пройденного
                else
                {
                    loolCounter++;
                    cornerCounter = 4;
                    Console.WriteLine("Switch to 4");
                }                
                break;
            case 4:
                if (j > loolCounter)
                {
                    j--; //Движемся вверх до границы пройденного 
                }
                else
                    {
                        cornerCounter = 1;
                        Console.WriteLine("Switch to 1");
                    }
                break;
        }
    }
    return result;
}

void Ex5()
{
    int x2;
    x2 = int.Parse(Console.ReadLine());
    int[,] spiral = CreateSpiralArr(x2);
    PrintComplexArrInt(spiral);
}

Ex5();