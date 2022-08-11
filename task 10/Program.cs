// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int number = ReadInt("Введите трехзначное число: ");

int ReadInt(string message)
{
    Console.Write(message);   
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(DeleteSecondDigit(number));

int DeleteSecondDigit(int number)
{
    int first = number / 10;
    int second = first % 10;
    return second;
}


