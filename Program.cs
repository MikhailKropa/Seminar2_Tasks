/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write ("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine());
int s1 = num / 10;
int s2 = s1%10;
Console.WriteLine($"вторая цифра числа - {s2}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите  число: ");
string num = Convert.ToString(Console.ReadLine());

    if(num.Length >= 3)
      Console.WriteLine(num[2]);
      
        else    
           Console.WriteLine("третьей цифры нет");

*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("этот день выходной -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("этот день не выходной -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);
