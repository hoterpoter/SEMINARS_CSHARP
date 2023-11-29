/*Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.*/

Console.Write("Введите целое число из отрезка [10, 99]: ");
int inputNumber = int.Parse(Console.ReadLine());

if (inputNumber < 10 || inputNumber > 99)
{
   Console.WriteLine("Число вне допустимого диапазона.");
   return;
}

int tensDigit = inputNumber / 10;
int onesDigit = inputNumber % 10;

int maxDigit = Math.Max(tensDigit, onesDigit);

Console.WriteLine($"Наибольшая цифра числа {inputNumber}: {maxDigit}");