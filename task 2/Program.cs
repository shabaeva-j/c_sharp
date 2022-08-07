// Задача 2: Напишите программу, которая на вход принимает два числа и выдает какое число больше, а какое меньше

Console.Write ("Введите первое число ");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число ");
int numberB = Convert.ToInt32 (Console.ReadLine());

if (numberA > numberB)

{
 Console.WriteLine (numberA + " больше числа " + numberB);
}

if (numberA < numberB)

{
 Console.WriteLine (numberA + " меньше числа " + numberB);
}

