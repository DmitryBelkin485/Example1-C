Console.Clear();

// int i = 0;

// while (i < 10)
// {
//     i += 2;
//     Console.WriteLine(i);
// }

// // Семинар 1

// // // 1 Напишите программу, которая на вход принимает число и выдает его квадрат
// Console.Clear();

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// // int sqrt = number * number;
// // number *= number;
// // number = number *number; 

// int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

// Console.WriteLine("Число в квадрате: " + sqrt1);




// //Напишите программу которая на вход принимает одно число(N).
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int B = -N;
// while (B <= N)
// {
//     Console.Write(B + " ");
//     B++;
// }





// // напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

// int number = new Random().Next(10, 100);
// Console.WriteLine(number);

// if (number / 10 > number % 10)
// {
//     Console.WriteLine(number/10);
// }
// else
// {
// Console.WriteLine(number % 10);
// }





// // Напишите программу, которая выводит случайно трехзначное число и удаляет вторую цифру этого числа.

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// // int x1 = number / 100;
// // int x2 = number % 10;
// // Console.WriteLine($"{x1}{x2}");
//  Console.WriteLine($"{(number / 100)*10 + number % 10}");  //Альтернативный вариант вывода.

// // Напишите программу,которая будет принимать на вход два числа и выводить,является ли второе число
//  кратным первому.Если число 2 не кратно числу 1, то программа выводит остаток от деления.


// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a != 0 && b != 0)
// {
//     if (a > b)
// {
//     if (a % b == 0)
//     {
//         Console.WriteLine($"{a} кратно {b}");
//     }
//     else
//     {
//         Console.WriteLine(a % b);
//     }
// }

// if (a < b)
// {
//     if (b % a == 0)
//     {
//         Console.WriteLine($"{b} кратно {a}");
//     }
//     else
//     {
//         Console.WriteLine(b % a);
//     }
// }
// }
// else
// {
//     Console.WriteLine("Ваше число равно нулю. Введите другое ");
// }





// // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 7 == 0 && a % 23 == 0)
// {
//     Console.WriteLine($"Число {a} кратно одновременно 7 и 23");
// }
// else
// {
//     Console.WriteLine($"Число {a} не кратно одновременно 7 и 23");
// }




// // Напишите программу,которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a * a ==  b || b * b == a)
// {
//     Console.WriteLine("первое число является квадратом другого");
// }
// else
// {
//     Console.WriteLine("первое число не является квадратом другого");
// }
