/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
double GetPower(int a, int b)
{
    int buf = 1;
    for (int i = 1; i <= b;i++)
    {
        buf *= a;
    }
    return buf;
}

int GetPowerDidgit()
{
    int a = -1;
    Console.WriteLine("Enter natural digit");
    while(a < 0)
    {
        a = int.Parse(Console.ReadLine());
        if (a < 0) Console.WriteLine("wrong digit, try again");
    }
    return a;
}

int GetSimpleDigit()
{
    Console.WriteLine("Enter some digit");
    return int.Parse(Console.ReadLine());
}

int A,B;

A = GetSimpleDigit();
B = GetPowerDidgit();

Console.WriteLine(GetPower(A,B));

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetSumOfDigit(int x)
{
    int buf = x % 10;
    while(x > 10)
    {
        x /= 10;
        buf += x % 10;
    }
    return buf;
}

A = GetSimpleDigit();
Console.WriteLine(GetSumOfDigit(A));

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
int[] CreateRandArr(int len, int min, int max)
{
    int[] buf = new int[len];
    Random rand = new Random();
    for(int i = 0 ; i< len;i++)
    {
        buf[i] = rand.Next(min,max+1);
    }
    return buf;
}

void ReturnArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1;i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}

int[] GetEntryDigit()
{
    int[] arr = new int[3];
    Console.Write("Enter length: ");
    arr[0] = int.Parse(Console.ReadLine());
    Console.Write("Enter min: ");
    arr[1] = int.Parse(Console.ReadLine());
    Console.Write("Enter max: ");
    arr[2] = int.Parse(Console.ReadLine());
    return arr;
}
int[] inpput = new int[3];
inpput = GetEntryDigit();
ReturnArr(CreateRandArr(inpput[0],inpput[1],inpput[2]));