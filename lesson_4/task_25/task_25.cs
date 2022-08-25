// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

double NumberDegree(int one, int two){
    double result = Math.Pow(one, two);
    return  result;
}


double numResult = NumberDegree(numOne, numTwo);
Console.WriteLine(numResult);






