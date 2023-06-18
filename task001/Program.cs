Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. ");
Console.Write("Введи любое трёхзначное число: ");
int Number = int.Parse(Console.ReadLine());
string number = Convert.ToString(Number);
Console.WriteLine("Вторая цифра этого числа: "+number[1]);

