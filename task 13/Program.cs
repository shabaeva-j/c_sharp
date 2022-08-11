// Задача 13: Напишите программу, которая выводиит третью цифру заданного числа или сообщает, что третьей цифры нет

if (numberA > 99)
{
    while(numberA >= 1000)
    {
        int requiredNumber = (numberA / 10);
        numberA  = requiredNumber; 
    }
    Console.WriteLine ("Третья цифра Вашего числа: " + numberA % 10);
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());