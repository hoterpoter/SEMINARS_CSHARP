// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// Задаем прямоугольный двумерный массив
int[,] array = {
            {20, 25, 3},
            {55, 5, 6},
            {57, 9, 9},
            {9, 25, 4}
        };

// Выводим исходный массив с помощью метода PrintArray
Console.WriteLine("Исходный массив:");
PrintArray(array);

// Находим строку с наименьшей суммой элементов с помощью метода FindRowWithMinSum
int minSumRow = FindRowWithMinSum(array);

// Выводим результат
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");

static void PrintArray(int[,] arr)
{
   int rows = arr.GetLength(0);
   int cols = arr.GetLength(1);

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < cols; j++)
      {
         Console.Write(arr[i, j] + " ");
      }
      Console.WriteLine();
   }
   Console.WriteLine();
}

// Метод для нахождения строки с наименьшей суммой элементов
static int FindRowWithMinSum(int[,] arr)
{
   int rows = arr.GetLength(0);
   int cols = arr.GetLength(1);

   int minSum = int.MaxValue;
   int minSumRow = -1;

   for (int i = 0; i < rows; i++)
   {
      int rowSum = 0;

      for (int j = 0; j < cols; j++)
      {
         rowSum += arr[i, j];
      }

      if (rowSum < minSum)
      {
         minSum = rowSum;
         minSumRow = i;
      }
   }

   return minSumRow;
}

