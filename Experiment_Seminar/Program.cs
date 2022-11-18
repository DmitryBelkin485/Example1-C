// Console.Clear();

// int i = 0;

// while (i < 10)
// {
//     i += 2;
//     Console.WriteLine(i);
// }

// //SEMINAR-1 _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

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



// //SEMINAR-2 _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

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


//  SEMINAR-3 _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _

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

// //SEMINAR-4 _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

// //Разбор задачи на нахождение ПАЛИНДРОМА.

// int numberB(int numB)
// {
//     int num = 0;
//     int count = 100000;

//     while (count >= 10)
//     {
//         num = num + (numB % 10) * (count / 10);
//         numB = numB / 10;

//         count = count / 10;
//     }
//     return num;
// }

// Console.WriteLine("Введите пятизначное число");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 99999 && number > 9999)
// {
//     if (number == numberB(number))
//     {
//         Console.WriteLine($"Число {number} палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number} не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine($"Неверный ввод");
// }


// //Разбор задачи на нахождение координат в 3D пространстве.

// Console.Clear();
// Console.Write("Введите X1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите Z1: ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите Z2: ");
// int z2 = int.Parse(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

// Console.WriteLine($"d={d:f3}");


// //Разбор задачи, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.Write($"{Math.Pow(i, 3)} ");    // //Console.Write($"{i * i * i}");
// }

// //Разбор задачи, которая принимает на вход число (A) и выдает сумму чисел от 1 до A.

// void GetSumNums(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= Math.Abs(number); i++)
//     {
//         sum += i;
//     }
//     Console.WriteLine($"Cумма цифр от 1 до введенного числа: {sum}");

// }

// Console.Clear();
// // GetSumNums(5);
// Console.Write("Введите число: ");            // // int n = Convert.ToInt32(Console.ReadLine());   // // GetSumNums(n)
// GetSumNums(int.Parse(Console.ReadLine()));   // //GetSumNums(Convert.ToInt32(Console.ReadLine()));

// //Разбор задачи, которая принимает на вход число N и выдает количество цифр в числе.

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int sum = GetCountNums(num);

// Console.WriteLine($"Количество цифр = {sum}");

// int GetCountNums(int number)
// {
//     int count = 0;
//     while (number > 0)
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }

// //Напишите программу, которая выводит массив из 8 элементов,
// //заполненный нулями и единицами в случайном порядке.

// int[] array = GetBinaryArray(58);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] GetBinaryArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(2);
//     }
//     return result;
// }
// //SEMINAR-5 _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 

// // Создание и вывод массива

// // VARIANT-1.

// int[] array = {8, 0, 100};
// Console.WriteLine($"[{String.Join(",", array)}]");

// // VARIANT-2.

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// // VARIANT-3.
// Console.Clear();
// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// // VARIANT-4.

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].Найдите сумму отрицательных и положительных элементов массива.

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int SumPol = 0;
// int SumNeg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         SumPol += myArray[i];
//     else
//         SumNeg += myArray[i];
// }
// Console.WriteLine($"Сумма положительных: {SumPol}. Сумма отрицательных: {SumNeg}");


// // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Console.Clear();
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int[] array = CreateRandomArray(5, -10, 10);
// Console.WriteLine($"[{String.Join(",", array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
// }
// Console.WriteLine($"[{String.Join(",", array)}]");



// //Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// //4; массив [6, 7, 19, 345, 3] -> нет
// //-3; массив [6, 7, 19, 345, 3] -> да

// int[] array = CreateRandomArray(10, -10, 10);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine("Введите число: ");
// int x = int.Parse(Console.ReadLine());
// bool serge = false;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == x)
//     {
//         serge = true;
//     }
// }
// Console.WriteLine(serge ? "ДА" : "НЕТ");


// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = CreateRandomArray(123, -200, 200);
// Console.WriteLine($"[{String.Join(",", array)}]");
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

