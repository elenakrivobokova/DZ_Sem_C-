// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size, int minValue, int maxValue)
{
  double[] array = new double[size];
  var rand = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    //array[i] = Math.Round(rand.NextDouble(), 3); // ддесятичные числа от 0 до 1, округденные до 3х знаков после запятой
    //array[i] = Random.NextDouble() * (maxValue - minValue) + minValue //рекомендуемый Майкрософт метод генерации чисел с плавающей точкой в выбранном диапазоне
    array[i] = Math.Round(rand.Next(minValue, maxValue) + rand.NextDouble(), 3); //случайная выдача вещественных чисел
  }
  return array;
}

void PrintArray(double[] array)
{
  System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double MaxElemdouble(double[] array)
{
  int i = 0;
  double max = array[i];
  for (i = 0; i < array.Length-1; i++)
  {
    if (array[i] < array[i+1])
    {
      max = array[i+1];
    }
    else
    {
      max = array[i];
    }
  }
  return max;
}

double MinElemdouble(double[] array)
{
  int i = 0;
  double min = array[i];
  for (i = 0; i < array.Length-1; i++)
  {
    if (array[i] > array[i+1])
    {
      min = array[i+1];
    }
    else
    {
      min = array[i];
    }
  }
  return min;
}

void DifferenceMinMax(double min,double max)
{
  System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max-min}");
}

double[] myArray = GenerateArray(6, -10, 10); 
//ПРОВЕРКА double[] myArray = {3, 7, 22, 2, 78}; 
PrintArray(myArray);
double MaxPosition = MaxElemdouble(myArray);
double MinPosition = MinElemdouble(myArray);
DifferenceMinMax(MinPosition, MaxPosition);


