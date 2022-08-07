// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел


Console.Write ("Введите первое число ");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число ");
int numberB = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите третье число ");
int numberC = Convert.ToInt32 (Console.ReadLine());

if (numberA > numberB)
{
 Console.WriteLine (numberA + " является максимальным числом ");
}
if (numberA > numberC)
{
Console.WriteLine (numberA + " является максимальным числом ");
}


else
{
   Console.WriteLine (numberC + " является максимальным числом "); 
}

