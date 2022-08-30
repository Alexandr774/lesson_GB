// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество цифр");
int len = Convert.ToInt32(Console.ReadLine());

int[] NewArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write($"число {i + 1} = ");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }
    return array;
}
int PositiveNumberCounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int reselut = PositiveNumberCounter(NewArray(len));
Console.WriteLine($"количетсво положительных чисел состовляет: {reselut} шт");