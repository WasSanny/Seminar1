// Программа, которая принимает на вход 2 числа и выдает,
// какое число большее, какое меньшее.

//int numberA = -8;
//int numberB = -10;

Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine(), out int numberA);
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine(), out int numberB);

if (numberA < numberB)
{
  Console.Write("min = ");
  Console.WriteLine(numberA);
  Console.Write("max = ");
  Console.WriteLine(numberB);
}
else
{
  Console.Write("max = ");
  Console.WriteLine(numberA);
  Console.Write("min = ");
  Console.WriteLine(numberB);
}