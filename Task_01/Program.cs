//Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

using System;
class Program
{
   static void Main()
   {
      Console.WriteLine("Введите число для проверки:");
      if (int.TryParse(Console.ReadLine(), out int number))
      {
         if (number % 7 == 0 && number % 23 == 0)
         {
            Console.WriteLine($"Число {number} кратно и 7, и 23.");
         }
         else
         {
            Console.WriteLine($"Число {number} не кратно и 7, и 23.");
         }
      }
      else
      {
         Console.WriteLine("Неправильное число , введите целое число.");
      }
   }
}
