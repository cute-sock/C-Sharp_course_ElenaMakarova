﻿// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46; 782 -> 72; 918 -> 98

void NumRandom()
{   
    int num = new Random().Next(100, 1000);
    Console.Write($"{num} -> {num / 10 + num % 10}");        
}

NumRandom();

// эту задачку я списала, но  удалила из формулы "разделить на 100 и умножить на 10", т.к. можно прото разделить на 10