﻿/*Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Task23(number);

void Task23(int curNumber)
{
    int count = 1;
    while( count <= curNumber)
    {
        Console.Write(Math.Pow(count,3) + " ");
        count++;
    }
}