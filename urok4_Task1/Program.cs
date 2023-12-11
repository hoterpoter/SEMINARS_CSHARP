// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
   Console.Write("Введите целое число: ");
   string input = Console.ReadLine();

   if (input.ToLower() == "q")// Проверяем, был ли введен 'q'
   {
      Console.WriteLine("Программа завершена по запросу пользователя.");
      break;
   }

   if (int.TryParse(input, out int number))// Пытаемся преобразовать введенную строку в целое число
   {
      if (IsSumOfDigitsEven(number))// Проверяем, является ли сумма цифр числа чётной
      {
         Console.WriteLine($"Сумма цифр числа {number} четная, программа завершена.");
         break;
      }
   }
   else
   {
      Console.WriteLine("Ошибка ввода. Введите целое число.");
   }
}

static bool IsSumOfDigitsEven(int num)// Метод для определения чётности суммы цифр числа
{
   int sum = 0;
   while (num != 0)
   {
      sum += num % 10;
      num /= 10;
   }
   return sum % 2 == 0;
}
