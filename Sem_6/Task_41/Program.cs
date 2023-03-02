// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


System.Console.WriteLine("Введите числа: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int PositivNum(int[] coll)
{
  int result = 0;
  for (int i = 0; i < coll.Length; i++)
  {
    if (coll[i] > 0)
    {
      result++;
    }
  }
  return result;
}

int quantity = PositivNum(array);
System.Console.WriteLine(quantity);

