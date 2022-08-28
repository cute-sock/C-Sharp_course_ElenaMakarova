﻿// Задача 1: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void ValueSet(int num)
{
    if (num == 0) return;
    // num==0 переменная num соотвествует нулю
    // получается что мы создали и запустили параллельно 5 функций (и сколько запустим, столько и будет висеть параллельно)
    // рекурсии едят много ресурсов и тем нехороши...
    ValueSet(num -1);
    Console.Write($"{num}, ");
}
ValueSet(5);
// 5 -это N, пятерка заходит в первой строчке в num