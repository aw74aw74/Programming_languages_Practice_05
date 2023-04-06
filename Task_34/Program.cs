//---------------------ЗАДАЧА---------------------
/*
Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет количество
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

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
  int res = 0;
  foreach (int el in col)
  {
    if (el % 2 == 0) res ++;
  }
  return res;
}

int[] array = new int[10];
FillArray(array, 100, 1000);
Console.WriteLine($"Дан массив: {String.Join(" ", array)}.");
Console.WriteLine($"Количество четных чисел: {SearchArray(array)}.");