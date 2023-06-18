Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. ");

Console.Write("Введи число: ");
int Number = int.Parse(Console.ReadLine());
string number = Convert.ToString(Number);
if (number.Length > 2)
{
  Console.WriteLine("третья цифра: " + number[2]);
}
else
  Console.WriteLine("Третьей цифры нет");
