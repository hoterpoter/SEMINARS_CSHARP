// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int arraySize = 10; // Задаем размер массива

Random random = new Random(); // Создаем генератор случайных чисел 

int[] array = new int[arraySize];
for (int i = 0; i < arraySize; i++)
{
   array[i] = random.Next(100, 1000); // генерируем случайное трехзначное число
}

Console.WriteLine("Сгенерированный массив:");
foreach (int number in array)
{
   Console.Write(number + " ");
}
Console.WriteLine();

// Находим количество четных чисел в массиве
int evenCount = CountEvenNumbers(array);

// Выводим результат
Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");

static int CountEvenNumbers(int[] arr)
{
   int count = 0;
   foreach (int number in arr)
   {
      if (number % 2 == 0)
      {
         count++;
      }
   }
   return count;
}

