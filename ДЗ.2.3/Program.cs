// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введи номер дня недели недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Ура, выходной -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Такого дня недели нет");
  }
  else Console.WriteLine("Продолжаем работать, этот день не выходной))) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);
