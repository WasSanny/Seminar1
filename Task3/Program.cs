// Программа, которая принимает на вход число и выдает, является ли число четным.

Console.WriteLine("Проверяем число на четность!");
Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine(), out int N);

var Prov = N % 2;

  if (Prov == 0)
  {
    Console.WriteLine("Вы ввели чётное число!");
  }
  else
  {
    Console.WriteLine("Вы ввели нечётное число!");
  }  