//Программа, которая принимает на вход 3 числа и выдает
// максимальное из этих чисел

Console.Write("Введите число №1: ");
int.TryParse(Console.ReadLine(), out int numberA);
Console.Write("Введите число №2: ");
int.TryParse(Console.ReadLine(), out int numberB);
Console.Write("Введите число №3: ");
int.TryParse(Console.ReadLine(), out int numberС);

int max = numberA;

if (numberB > numberA)
{
  max = numberB;
}
if (numberС > max)
{
  max = numberС;
}
Console.Write("Максимальное из трех чисел: ");
Console.WriteLine(max);

