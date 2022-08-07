// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным

Console.Write ("Введите первое число ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number % 2 == 0)
{
 Console.WriteLine (number + " является четным числом ");
}

else
{
   Console.WriteLine (number + " не является четным числом ");
} 
