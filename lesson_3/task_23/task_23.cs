// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Ввдеите число: ");
int EnterNum = Convert.ToInt32(Console.ReadLine());



string CubeNum(int number)
 {
   string result = "";
    for(int i = 1; i <= number; i++)
    {  
        result += $"{Math.Pow(i, 3)} ";
 }
   
   return result;
 }

 Console.WriteLine(CubeNum(EnterNum));