// Программа, принимающая на вход число (N), а на выходе
// показывает все четные числа от 1 до N

Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine(), out int number); // вводим число

    var even = 1; 

    while (even <= number)
    {
      if (even % 2 == 0)
      {
        Console.Write(even + " ");
      }
        even++;
    }
