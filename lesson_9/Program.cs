/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1
*/

void PrintPrew(int number)
{
    if (number > 0)
    {
        Console.Write($" {number}");
        PrintPrew(number - 1);
    } 
}

void Ex1()
{
    int input = int.Parse(Console.ReadLine());
    PrintPrew(input);
}

//Ex1();
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSumInt(int m, int n)
{
    if (m < n)
        m += GetSumInt(m + 1,n);
    return m;
}

void Ex2()
{
    int inputM = int.Parse(Console.ReadLine());
    int inputN = int.Parse(Console.ReadLine());
    int result = GetSumInt(inputM,inputN);
    Console.WriteLine(result);
}

//Ex2();

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetAkerm(int a, int b)
{
    if (a == 0) return b + 1;
    else 
    if (b == 0)
        return GetAkerm(a - 1, 1);
    else
        return GetAkerm(a-1,GetAkerm(a,b-1));
}

void Ex3()
{
    int inputM = int.Parse(Console.ReadLine());
    int inputN = int.Parse(Console.ReadLine());
    int result = GetAkerm(inputM,inputN);
    Console.WriteLine(result);
}

Ex3();
