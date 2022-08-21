// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");

string num(){
 int input = Convert.ToInt32(Console.ReadLine());
 string numText = Convert.ToString(input);
if (numText.Length > 2){
  return "третья цифра -> " + numText[2];
}
else {
  return "-> третьей цифры нет";
}

}

Console.WriteLine(num());
