/*Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.*/
using System;

class Program
{
   static void Main()
   {
      Console.WriteLine("Введите целое число из отрезка [10, 99]: ");

      // Ввод числа с клавиатуры
      int number;
      while (true)
      {
         if (int.TryParse(Console.ReadLine(), out number) && number >= 10 && number <= 99)
            break;
         else
            Console.WriteLine("Введите корректное число из отрезка [10, 99]: ");
      }

      // Находим наибольшую цифру
      int maxDigit = number % 10 > number / 10 ? number % 10 : number / 10;

      Console.WriteLine($"Наибольшая цифра в числе {number} - {maxDigit}");
   }
}
