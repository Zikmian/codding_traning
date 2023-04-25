/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
int[] EnterArray(int len)
{
    int[] buf = new int[len];
    Console.WriteLine("Enter your numbers:");
    for(int i = 0 ; i< len;i++)
    {
        buf[i] = int.Parse(Console.ReadLine());
    }
    return buf;
}

int CountPositive(int[] arr)
{
    int counter = 0;
    foreach(int num in arr)
    {
        if (num > 0) counter++;
    }
    return counter;
}

Console.WriteLine("Enter len:");
int length = int.Parse(Console.ReadLine());
int[] array = EnterArray(length);
int count = CountPositive(array);
Console.WriteLine($"There are {count} positive");
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

k1 = 5, b1 = 2, k2 = 9, b2 = 4  -> (-0,5; -0,5)
*/
double[] InputCof()
{
    double[] cofs = new double[2];
    Console.WriteLine("Eaqual y = k*x + b");
    Console.Write("input k:");
    cofs[0] = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("input b:");
    cofs[1] = Convert.ToDouble(Console.ReadLine()); 
    return cofs;
}

bool ValidateCords(double[] eaq1, double[] eaq2)
{
    bool flag = true;
    if (eaq1[0] == eaq2[0]) 
    {
        flag = false;
        if (eaq1[1] == eaq2[1]) 
            Console.WriteLine("Lines are the same");
        else 
            Console.WriteLine("Lines are parallel");
    }
    return flag;
}

double[] FindCross(double[] eaq1, double[] eaq2)
{
    double x,y;
    x = (eaq1[1] - eaq2[1]) / (eaq2[0] - eaq1[0]);
    y = x * eaq1[0] + eaq1[1];
    double[] cords = new double[]{x,y};
    return cords;
}

double[] line1 = InputCof();
double[] line2 = InputCof();

if (ValidateCords(line1,line2))
    {
    double[] cords = FindCross(line1,line2);
    Console.WriteLine($"Cross on ({cords[0]} , {cords[1]})");
    }
