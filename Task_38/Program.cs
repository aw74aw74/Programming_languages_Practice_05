//---------------------ЗАДАЧА---------------------
/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

//---------------------РЕШЕНИЕ---------------------
int[] FillArray(int[] col, int min, int max)
{
  for (int index = 0; index < col.Length; index++)
  {
    col[index] = new Random().Next(min, max);
  }
  return col;
}

int SearchArray(int[] col)
{
  int min;
  int max = min = col[1];
  for (int i = 0; i < col.Length; i++)
  {
    if (col[i] < min)
    {
      min = col[i];
    }
    if (col[i] > max)
    {
      max = col[i];
    }
  }
  return max - min;
}

int[] array = new int[10];
FillArray(array, 0, 100);
Console.WriteLine($"Дан массив: {String.Join(" ", array)}.");
Console.WriteLine($"Разница крайних значений: {SearchArray(array)}.");
