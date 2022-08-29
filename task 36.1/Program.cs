// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine($"Введите массив чисел: ");
int[] numbers = new int[10];
int result = 0;
FillArrayRandomNumbers(numbers);
WriteArrayRandom(numbers);
 
 for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers [i] % 2 == 1)
        {
           result = result + numbers[i];
        }   
    }Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях составляет = {result}");

void WriteArrayRandom(int[] array)
{
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

void FillArrayRandomNumbers(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

    Console.WriteLine();
