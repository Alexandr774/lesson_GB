// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = new int[10];
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
        Console.Write(array[i] + " ");
    }
}
int FindUnevenIndexNumberSumm(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ += array[i];
        }
    }
    return summ;
}
PrintArray(array);
Console.WriteLine();
int display2 = FindUnevenIndexNumberSumm(array);
Console.WriteLine(display2);