Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. ");
Console.Write("Введи цифру, обозначающую день недели: ");
int daynumber = int.Parse(Console.ReadLine());

void week (int daynumber) {
  if (daynumber == 6 || daynumber == 7) {
  Console.WriteLine("Ура!!! Выходной!!! ");
  }
  else if (daynumber < 1 || daynumber > 7) {
    Console.WriteLine("Вы что-то неправильно ввели (В неделе 7 дней)");
  }
  else Console.WriteLine("Как жаль что это не выходной =( ");
}

week(daynumber);