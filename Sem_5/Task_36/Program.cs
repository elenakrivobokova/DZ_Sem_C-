// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void GenerateArray(int[] pos)
{
  int count = pos.Length;
  int index = 0;
  while (index < count)
  {
    pos[index] = new Random().Next(-100, 100);
    index++;
  }
}

void PrintArray(int[] array) // вывод массива
{
  System.Console.WriteLine("[" + string.Join(". ", array) + "]");
}
int SumOddIndexElements(int[] col) //поиск суммы элементов с нечетными индексами
{
  int result = 0;
  int i = 1;
  for (i = 1; i < col.Length; i += 2)
  {
    result += col[i];
  }
  return result;
}

// ЗАПУСК

int[] num = new int [10];
GenerateArray(num);
PrintArray(num);
SumOddIndexElements(num);
System.Console.WriteLine($"Сумма элементов на нечетных позициях {SumOddIndexElements(num)}");


