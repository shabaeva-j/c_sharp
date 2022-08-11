// Задача 13: Напишите программу, которая выводиит третью цифру заданного числа или сообщает, что третьей цифры нет

int randomNumber = new Random().Next(10,999);
Console.WriteLine(randomNumber);
int x = 99;
if (randomNumber < x)
{
Console.WriteLine( "Третьей цифры нет");
}
else 
{
int number = randomNumber % 10;
Console.WriteLine(number);
}