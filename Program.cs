// See https://aka.ms/new-console-template for more information
int a, b, c;
string input_a, input_b, input_с;
input_a = Console.ReadLine();
a = int.Parse(input_a);
input_b = Console.ReadLine();
b = int.Parse(input_b);

// задача 2
if (a > b) 
{
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}

// задача 4
/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

input_a = Console.ReadLine();
a = int.Parse(input_a);
input_b = Console.ReadLine();
b = int.Parse(input_b);
input_с = Console.ReadLine();
c = int.Parse(input_с);
int max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);

//Задача 6
/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
input_a = Console.ReadLine();
a = int.Parse(input_a);

if (a%2 == 0) Console.WriteLine("yep"); else Console.WriteLine("Nope");

//Задача 8
/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
input_a = Console.ReadLine();
a = int.Parse(input_a);
int i = 1;
while (i < a)
{
    if (i%2 == 0) Console.Write($"{i} ");
    i++;
}