// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите элементов, стоящих на нечётных позициях.


Console.Write(" Введите массив чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
FillArrayRandomNumbers (numbers);
PrintArray (numbers);
int sum= 0;


for (int i = 0; i <numbers.Length; i++ )
{ 
if (i % 2 != 1)
 {
    sum = sum + numbers[i];
 }
}
Console.WriteLine($" Сумма элементов чисел равна:  {sum}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
        Console.WriteLine();
    }
} 