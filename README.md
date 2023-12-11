# Памятка 
| __Метод для определения чётности суммы цифр числа__

``` 
static bool IsSumOfDigitsEven(int num)
{
   int sum = 0;
   while (num != 0)
   {
      sum += num % 10;
      num /= 10;
   }
   return sum % 2 == 0;
}
```
| __Метод для подсчета четных чисел в массиве__

```
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
```

| __Метод для переворота одномерного массива__

```
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
```

| __Метод для вывода массива на экран__

```
static void PrintArray(int[] arr)
{
   foreach (int element in arr)
   {
      Console.Write(element + " ");
   }
   Console.WriteLine();
}
```
 | __Метод для получения значения элемента по его позиции__
```
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
```

1. __static__ -  Это ключевое слово, указывающее, что метод является статическим, т.е., он принадлежит типу (классу), а не конкретному экземпляру объекта этого типа.

2. __int?__ - Это объявление возвращаемого типа метода. В данном случае, метод возвращает целое число (int), но с дополнением ?, что означает, что тип может принимать значение null. Такой тип называется nullable int.

3. __GetArrayElement__ - Это имя метода.

4. __(int[,] arr, int row, int col)__ - Это параметры метода. Метод принимает три параметра:

+ arr - Двумерный массив, в котором мы ищем элемент.
+ row - Номер строки, где находится элемент.
+ col - Номер столбца, где находится элемент.

Таким образом, этот метод GetArrayElement используется для получения значения элемента в заданных позициях (row, col) из двумерного массива (arr). Возвращаемый тип int? указывает, что метод может вернуть целое число или null, в случае если позиции находятся за пределами размеров массива.


| __Метод для вывода двумерного массива на экран__

```
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
```
| __Метод для нахождения строки с наименьшей суммой элементов__
```
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
```
