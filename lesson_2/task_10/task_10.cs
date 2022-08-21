//    Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1 

Console.WriteLine("Введите трех значное число:");

int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"вторым числом является: {num2(input)}");


int num2(int arg){

int numTwo = arg / 10 % 10;

return numTwo;
} 






