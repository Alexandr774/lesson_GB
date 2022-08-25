// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int SumDigitsNumber (int number)
{
string str = number.ToString();
char one;
 int[] mass = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    one = str[i];
   int gap =int.Parse(one.ToString());
    mass[i] = gap; 
}
int result = 0;
for (int j = 0; j < str.Length; j++)
{
    result = result+mass[j];
}
return result;
}

int resultNumber = SumDigitsNumber(N);
Console.WriteLine(resultNumber);