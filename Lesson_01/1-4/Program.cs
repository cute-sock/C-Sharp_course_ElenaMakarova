﻿/// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());
// if (a<0)
int i = -a;
while (i <= a)
{
    Console.WriteLine(i);
    // index = index + 1 можно написать как i++
    i++;
}
