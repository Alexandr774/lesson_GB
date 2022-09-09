// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int summ = 0;

int FindSumm(int numberM, int numberN)
{
    if (numberM <= numberN)
    {
        summ += numberM;
        numberM++;
        FindSumm(numberM, numberN);
    }
    return summ;
}
Console.WriteLine(FindSumm(numberM, numberN));