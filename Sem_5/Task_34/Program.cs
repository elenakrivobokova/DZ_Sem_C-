// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size, int leftRange, int rightRange)//создание массива
{
  int[] array = new int[size];
  var rand = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rand.Next(leftRange, rightRange); // -9, 9 + 1
  }
  return array;
}

void PrintArray(int[] array) // вывод массива
{
  System.Console.WriteLine("[" + string.Join(". ", array) + "]");
}

void SumEvenNumbers(int[] array, out int Sum) // поиск кол-ва четных элементов
{
  Sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) 
    {
      Sum++;
    }
  }
}

// ЗАПУСК
int[] myArray = GenerateArray(20, 100, 1000);
PrintArray(myArray);
SumEvenNumbers(myArray, out int Sum);
System.Console.WriteLine($"Количество четных  элементов равна {Sum}");

