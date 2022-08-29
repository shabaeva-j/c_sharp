//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Line (string message, int location )
{
    Console.WriteLine(message);
    int[] result = new int[2];
    result[0] = ReadInt($"Введите значение k{location}:");
    result[1] = ReadInt($"Введите значение b{location}:");
    return result;
}

int[] line1 = Line("Укажем первую линию у = k1 * x + b1 ", 1);
int[] line2 = Line("Укажем вторую линию у = k2 * x + b2 ", 2);

double x = (line1[1] - line2[1]) / (line2[0] - line1[0]);
double y = ((line1[0]+line2[0])*x+line1[1]+line2[1])/2;

if (line1[1] == line2[1])
{
    Console.WriteLine($"Линии пересекутся в следующей точке : ({0}, {line1[1]})");
    return;
}

Console.WriteLine($"Линии пересекутся в следующей точке: {x}, {y}");

