// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

using System;

class Program
{
   static void Main()
   {
      Console.WriteLine("Введите координаты точки (X и Y):");

      Console.Write("X: ");
      if (double.TryParse(Console.ReadLine(), out double x))
      {
         Console.Write("Y: ");
         if (double.TryParse(Console.ReadLine(), out double y))
         {
            DetermineQuadrant(x, y);
         }
         else
         {
            Console.WriteLine("Некорректный ввод для Y. Пожалуйста, введите числовое значение.");
         }
      }
      else
      {
         Console.WriteLine("Некорректный ввод для X. Пожалуйста, введите числовое значение.");
      }
   }

   static void DetermineQuadrant(double x, double y)
   {
      if (x > 0 && y > 0)
      {
         Console.WriteLine("Точка находится в первой координатной четверти.");
      }
      else if (x < 0 && y > 0)
      {
         Console.WriteLine("Точка находится во второй координатной четверти.");
      }
      else if (x < 0 && y < 0)
      {
         Console.WriteLine("Точка находится в третьей координатной четверти.");
      }
      else if (x > 0 && y < 0)
      {
         Console.WriteLine("Точка находится в четвёртой координатной четверти.");
      }
      else
      {
         Console.WriteLine("Точка находится на координатной оси.");
      }
   }
}
