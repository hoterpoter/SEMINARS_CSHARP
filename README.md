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

// __Метод для переворота одномерного массива__

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


```
// Метод для вывода массива на экран
static void PrintArray(int[] arr)
{
   foreach (int element in arr)
   {
      Console.Write(element + " ");
   }
   Console.WriteLine();
}
```
