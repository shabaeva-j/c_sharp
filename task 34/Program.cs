// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine($"Введите массив чисел: ");
int[] numbers = new int[10];

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(100,1000);
  }
}

void WriteArrayRandom(int[] array)
{
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array){
    int count = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

FillArray(numbers, 100, 1000);
WriteArrayRandom(numbers);
Console.WriteLine();

int count= QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве составляет: {count}");
