// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

Console.WriteLine("Исходный массив:");
PrintArray(array);

// Меняем местами первую и последнюю строки
SwapRows(array, 0, array.GetLength(0) - 1);

Console.WriteLine("Массив после обмена строк:");
PrintArray(array);


// Метод для вывода двумерного массива на экран
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

// Метод для обмена местами двух строк в двумерном массиве
static void SwapRows(int[,] arr, int row1, int row2)
{
   int cols = arr.GetLength(1);

   for (int j = 0; j < cols; j++)
   {
      int temp = arr[row1, j];
      arr[row1, j] = arr[row2, j];
      arr[row2, j] = temp;
   }
}


