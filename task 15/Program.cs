﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите день недели начиная от 1 до 7: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 7 || number ==  6)
{
    Console.WriteLine(" Выходной ");
}
else if (number == 1 || number ==  2 || number ==  3 || number == 4 || number == 5)
{
    Console.WriteLine(" Будни " ); 
}




