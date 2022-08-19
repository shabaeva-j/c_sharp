// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers (number, len);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int x)
{
    int index = 0;
    while (x > 0)
    {
        x /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int a, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += a % 10;
        a /= 10;
    }
    Console.WriteLine(sum);
}