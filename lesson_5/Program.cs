int[] CreateRandArr(int len, int min, int max)
{
    int[] buf = new int[len];
    Random rand = new Random();
    for(int i = 0 ; i< len;i++)
    {
        buf[i] = rand.Next(min, max + 1);
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
    Console.WriteLine($"{arr[arr.Length-1]}]");
}

int len;

int[] arr;

int SearchEven(int[] input_arr)
{
    int count = 0;
    for (int i = 0; i < input_arr.Length;i++)
    {
        if (input_arr[i] % 2 == 0) count += 1;
    }
    return count;
}
arr = CreateRandArr(len,100,1000);
len = int.Parse(Console.ReadLine());
ReturnArr(arr);
Console.WriteLine(SearchEven(arr));

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
int min,max;
len = int.Parse(Console.ReadLine());
min = int.Parse(Console.ReadLine());
max = int.Parse(Console.ReadLine());
int[] input = CreateRandArr(len, min, max);
ReturnArr(input);
Console.WriteLine(CountOddNumbers(input));

int CountOddNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) if (i % 2 == 1) count += arr[i];
    return count;
}

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int FindMin(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++) if (arr[i] < min) min = arr[i];
    return min;
}
int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++) if (arr[i] > max) max = arr[i];
    return max;
}
int min = -1;
int max = min;
len = int.Parse(Console.ReadLine());
while (min < 0)
{
    Console.Write("Enter simple number:");
    min = int.Parse(Console.ReadLine());
    if (min < 0) Console.WriteLine("Wrong, try again");
}
while (max <= min)
{
    Console.Write("Now enter bigger simple number:");
    max = int.Parse(Console.ReadLine());
    if (max <= min) Console.WriteLine("Wrong, try again");
}
int[] input = CreateRandArr(len, min, max);
ReturnArr(input);
Console.WriteLine(FindMax(input) - FindMin(input));
