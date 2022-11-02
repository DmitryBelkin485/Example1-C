// Console.Clear();

// int i = 0;

// while (i < 10)
// {
//     i += 2;
//     Console.WriteLine(i);
// }

// // Семинар 1

// // 1 Напишите программу, которая на вход принимает число и выдает его квадрат
Console.Clear();

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

// int sqrt = number * number;
// number *= number;
// number = number *number; 

int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine("Число в квадрате: " + sqrt1);