/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

string input_a;
int a, i;
bool flag = true;

input_a = Console.ReadLine();
a = int.Parse(input_a);

while ((flag) & (a >10))
{
    i = 10;
    while (a / i > 10) i = i * 10; 
    if ((a>10) & (a / i != a % 10)) flag = false;
    a = (a % i) /10;
}

if (flag) Console.WriteLine("yes"); else Console.WriteLine("no");

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetDistance(int[] a, int[] b)
{
    double fir = Math.Pow(a[0] - b[0],2);
    double sec = Math.Pow(a[1] - b[1],2);
    double thi = Math.Pow(a[2] - b[2],2);
    return Math.Sqrt(fir + sec + thi);
} 

int[] GetCoords()
{
    int[] a = new int[3];
    a[0] = int.Parse(Console.ReadLine());
    a[1] = int.Parse(Console.ReadLine());
    a[2] = int.Parse(Console.ReadLine());
    return a;
}

int[] first = GetCoords();
int[] second = GetCoords();
Console.WriteLine(GetDistance(first,second));
/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

input_a = Console.ReadLine();
a = int.Parse(input_a);

for (i = 1; i <= a; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}
