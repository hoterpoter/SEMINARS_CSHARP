//  Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// Задаем одномерный массив
int[] array = { 1, 2, 3, 4, 5 };


Console.WriteLine("Исходный массив:");
PrintArray(array);

ReverseArray(array);

Console.WriteLine("Перевернутый массив:");
PrintArray(array);


// Метод для вывода массива на экран
static void PrintArray(int[] arr)
{
   foreach (int element in arr)
   {
      Console.Write(element + " ");
   }
   Console.WriteLine();
}

// Метод для переворота одномерного массива
static void ReverseArray(int[] arr)
{
   int left = 0;
   int right = arr.Length - 1;

   while (left < right)
   {
      // Обмен значениями между левым и правым элементами массива
      int temp = arr[left];
      arr[left] = arr[right];
      arr[right] = temp;

      // Смещение указателей внутрь массива
      left++;
      right--;
   }
}


