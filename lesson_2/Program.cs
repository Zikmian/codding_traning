// See https://aka.ms/new-console-template for more information
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
string input_a;
input_a = Console.ReadLine();
int a = int.Parse(input_a);

Console.WriteLine(a % 100 / 10 );

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
input_a = Console.ReadLine();
a = int.Parse(input_a);
int third = 0;
if (a / 1000 > 0)
{
    while (a / 1000 > 0)    
    {   
        a = a /10;
    }
    Console.WriteLine(a % 10);
}
else Console.WriteLine("no third digit");

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
input_a = Console.ReadLine();
a = int.Parse(input_a);

if ((a == 6) || (a == 7)) Console.WriteLine("yes"); 
else Console.WriteLine("no");