// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
// Для перебора элементов массива будет использован цикл foreach.
int[] array = { 2, 56, 6, 8, 8, 9, 76, 33, 23, 56 };

int evenCount = 0;

// for (int i = 0; i < array.Length; i++)
foreach (int number in array)
{
   if (number % 2 == 0)
   {
      evenCount++;
   }
}
Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");