﻿// Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
Degree(numberA, numberB);


void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}