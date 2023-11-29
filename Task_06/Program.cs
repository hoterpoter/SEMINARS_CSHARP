// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = { 54.56, 22.76, 23.43, 23.54, 25.43, 56.45, 67.23 };

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
   if (array[i] < min)
   {
      min = array[i];
   }
   else if (array[i] > max)
   {
      max = array[i];
   }
}

double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");