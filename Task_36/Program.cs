//---------------------ЗАДАЧА---------------------
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int SearchSumArray(int[] col)
{
  int res = 0;
  for (int i = 0; i < col.Length; i += 2)
  {
    res += col[i];
  }
  return res;
}

int[] array = new int[10];
FillArray(array, 0, 10);
Console.WriteLine($"Дан массив: {String.Join(" ", array)}.");
Console.WriteLine($"Сумма чисел нечётных элементов: {SearchSumArray(array)}.");