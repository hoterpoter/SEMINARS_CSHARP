// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// Создаем двумерный массив
int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

// Запрашиваем позиции элемента у пользователя
Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine());

// Получаем значение элемента или сообщение об отсутствии элемента
int? element = GetArrayElement(array, row, col);

if (element.HasValue)
{
   Console.WriteLine($"Значение элемента в позиции ({row}, {col}): {element.Value}");
}
else
{
   Console.WriteLine($"Элемента в позиции ({row}, {col}) не существует.");
}

// Метод для получения значения элемента по его позиции
static int? GetArrayElement(int[,] arr, int row, int col)
{
   int rows = arr.GetLength(0);
   int cols = arr.GetLength(1);

   if (row >= 0 && row < rows && col >= 0 && col < cols)
   {
      return arr[row, col];
   }
   else
   {
      return null;
   }
}


