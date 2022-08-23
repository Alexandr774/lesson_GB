// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());


 string result = polydromeCheck(number);
Console.WriteLine(result);


string polydromeCheck(int number)
{
      if (number < 100000 && number >= 10000)
    {
        char[] nums1 = number.ToString().ToCharArray();
            Array.Reverse(nums1);
            String num2 = new String(nums1);
            int number1 = Convert.ToInt32(num2);
                Console.WriteLine(number1);
    if(number1 == number)
    {
      return  "да"; 
    } 
    else 
    {
        return "нет";
    }
    }
      throw new Exception("Число не пятизначное");
}




