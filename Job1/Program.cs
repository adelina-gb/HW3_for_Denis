/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

Task(number);

void Task(string currentNumber)
{
    if(currentNumber[0] == currentNumber[4] &&
       currentNumber[1] == currentNumber[3]) 
    {
       Console.WriteLine("Число является палиндромом."); 
    }
    else Console.WriteLine("Число не является палиндромом.");
}

