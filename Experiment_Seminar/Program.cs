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


//  SEMINAR3 _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int GetQuarterFromCoordinate(int userX, int userY)
// {
//     int quarter = 0;
//     if (userX > 0 && userY > 0)
//     {
//         quarter = 1;
//     }
//     else if (userX < 0 && userY > 0)
//     {
//         quarter = 2;
//     }
//     else if (userX < 0 && userY < 0)
//     {
//         quarter = 3;
//     }
//     else if (userX > 0 && userY < 0)
//     {
//         quarter = 4;
//     }
//     return quarter;
// }
// Console.WriteLine("Введите координату X");
// int userX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int userY = Convert.ToInt32(Console.ReadLine());

// int quarter = GetQuarterFromCoordinate(userX, userY);
// if (quarter != 0)
// {
//     Console.WriteLine($"Точка с координатами [{userX}:{userY}] находится в {quarter} четверти");
// }
// else
// {
//     Console.WriteLine($"Точка с координатами [{userX}:{userY}] находится на одной из осей");
// }





// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void GetCoordinateFromQuarter(int Quarter)
// {
//     if (Quarter == 1)
//     {
//         Console.WriteLine("x>0 and y>0");
//     }
//     else if (Quarter == 2)
//     {
//         Console.WriteLine("x<0 and y>0");
//     }
//     else if (Quarter == 3)
//     {
//         Console.WriteLine("x<0 and y<0");
//     }
//     else if (Quarter == 4)
//     {
//         Console.WriteLine("x>0 and y<0");
//     }
//     else
//     {
//         Console.WriteLine("uncorrect quarter");
//     }

// }
// Console.WriteLine("Введите номер четверти");
// int Quarter = Convert.ToInt32(Console.ReadLine());
// GetCoordinateFromQuarter(Quarter);





// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// d = √(xb - xa)2 + (yb - ya)2

// Console.Clear();
// double Distance(int x1, int y1, int x2, int y2)
// {
//     double d = 0;
//     d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//     return d;
// }
// Console.WriteLine("enter coordinate");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Distance(x1, y1, x2, y2);
// Console.WriteLine(Math.Round(d, 2));

//для 3D
// {Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5)}"  




// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// void sqrt(int N)
// {
//     if (N > 0)
//     {
//         int count = 1;
//         while (count < N)
//         {
//             int result = count * count;
//             Console.Write(result + ", ");
//             count++;
//         }
//         Console.Write(N * N);
//     }
//     else
//     {
//         Console.WriteLine("Введите число больше 1");
//     }
// }
// Console.WriteLine("enter number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// sqrt(N);

