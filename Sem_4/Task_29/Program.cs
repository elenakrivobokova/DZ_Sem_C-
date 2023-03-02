// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int GetNumber(string text)
{
  System.Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int size, int leftNum, int rightNum)
{
  int[] arr = new int[size];
  var rand = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rand.Next(leftNum, rightNum);
  }
  return arr;
}

void PrintArray(int[] arr)
{
  System.Console.WriteLine("[" + string.Join("_ ", arr) + "]");
}

int Pos = GetNumber("Введите кол-во элементов в массиве: ");
int LeftN = GetNumber("Введите левую границу массива: ");
int RightN = GetNumber("Введите правую границу массива: ");
var myArray = GetArray(Pos,LeftN,RightN);
PrintArray(myArray);

