// (не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.
// Размер массива должен быть равен количеству цифр.
Console.Write("Введите натуральное число в диапазоне от 1 до 100000: ");
int number = int.Parse(Console.ReadLine()); // считывает введённое число с клавиатуры пользователя и преобразует из строки в целое число. 

if (number < 1 || number > 100000)
{
   Console.WriteLine("Введенное число находится вне нашего диапазона");
   return;
}

int numDigits = 0;
int tempNumber = number;
while (tempNumber > 0)
{
   tempNumber /= 10;
   numDigits++;
}

int[] digitsArray = new int[numDigits];
for (int i = 0; i < numDigits; i++)
{
   digitsArray[i] = number % 10;
   number /= 10;
}
Console.WriteLine("Массив из цифр числа:");
for (int i = 0; i < digitsArray.Length; i++)
{
   Console.Write(digitsArray[i] + " ");
}
