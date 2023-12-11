// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца

int[,] array = {
            {5, 32, 27, 2},
            {86, 15, 45, 93},
            {6, 22, 92, 11},
            {35, 38, 26, 15}
        };

Console.WriteLine("Исходный массив:");
PrintArray(array);

int[] minIndex = FindMinElementIndex(array); // находим индекс наименьшего элемента

// Удаляем строку и столбец с наименьшим элементом
int[,] newArray = RemoveRowAndColumn(array, minIndex[0], minIndex[1]);

Console.WriteLine("Массив после удаления строки и столбца:");
PrintArray(newArray);

static void PrintArray(int[,] arr)
{
   int rows = arr.GetLength(0);
   int cols = arr.GetLength(1);

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < cols; j++)
      {
         Console.Write(arr[i, j] + "\t");
      }
      Console.WriteLine();
   }
   Console.WriteLine();
}

static int[] FindMinElementIndex(int[,] arr)  // Метод для нахождения индексов наименьшего элемента
{
   int rows = arr.GetLength(0);
   int cols = arr.GetLength(1);

   int minValue = int.MaxValue;
   int[] minIndex = new int[2];

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < cols; j++)
      {
         if (arr[i, j] < minValue)
         {
            minValue = arr[i, j];
            minIndex[0] = i; // Номер строки
            minIndex[1] = j; // Номер столбца
         }
      }
   }

   return minIndex;
}

// Удаляем строку и столбец с наименьшим элементом с помощью метода
static int[,] RemoveRowAndColumn(int[,] arr, int rowToRemove, int colToRemove)
{
   int rows = arr.GetLength(0);
   int cols = arr.GetLength(1);

   int[,] newArray = new int[rows - 1, cols - 1];

   int newRow = 0;
   for (int i = 0; i < rows; i++)
   {
      if (i != rowToRemove)
      {
         int newCol = 0;
         for (int j = 0; j < cols; j++)
         {
            if (j != colToRemove)
            {
               newArray[newRow, newCol] = arr[i, j];
               newCol++;
            }
         }
         newRow++;
      }
   }

   return newArray;
}


