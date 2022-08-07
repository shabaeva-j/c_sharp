// Задача 8: Напишите программу, которая на вход принимает число N, а на выходе покащывет все четные числа от 1 до N
Console.Write ("Введите число ");
int number = Convert.ToInt32 (Console.ReadLine()); 
int numberX = 1; 

while (numberX <= number)
{if (numberX % 2 == 0) 
  numberX++;
 Console.WriteLine (numberX + ",");
  numberX++ ;
}