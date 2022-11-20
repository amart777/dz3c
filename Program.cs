//Console.WriteLine("Введите натуральное число ");
//int x=Convert.ToInt32 (Console.ReadLine());
//int y = x*x;
//Console.WriteLine("Вот посчитали квадрат введенного вами числа и это цифра - "+y);
//if (x==8)
//{
//   Console.WriteLine("Вы ввели восемь");
//}
//else Console.WriteLine("Вы ввели число отличное от 8");
//int i = 0;
//while (i<x)
//{
//    Console.WriteLine($"Счетчик цикла равен {i}");
//    i=i+1;
//}
// Console.WriteLine("Введите первое число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int y=Convert.ToInt32 (Console.ReadLine());
// if (x*x == y) Console.WriteLine("Второе число является квадратом первого");
// else if (y*y == x) Console.WriteLine("Первое число является квадратом второго");
// else Console.WriteLine("Нет");

// ДЗ 1 Задача 2
// Console.WriteLine("Введите первое число ");
// int a=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b=Convert.ToInt32 (Console.ReadLine());
// if (a > b) Console.WriteLine($"Первое число больше второго и равно {a}");
// else if (a < b) Console.WriteLine($"Второе число больше первого и равно {b}");
// else Console.WriteLine("Числа равны");

// ДЗ 1 Задача 4
// Console.WriteLine("Введите первое число ");
// int a=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int b=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите третье число ");
// int c=Convert.ToInt32 (Console.ReadLine());
// int i=0;
// if (a > b) i=a;
// else i=b;
// if (i < c) i=c;
// Console.WriteLine($"Максимальное из трех чисел = {i}");

// ДЗ 1 Задача 6
// Console.WriteLine("Введите число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// int y=x % 2;
// if (y == 0) Console.WriteLine("Число чётное");
// else Console.WriteLine("Число не чётное");

// ДЗ 1 Задача 8
// Console.WriteLine("Введите число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// int i = 1;
// while (i <= x)
// {
//     if (i % 2 == 0) Console.Write(i+", "); 
//     i=i+1;
// }
// ___________________________________________________________________________________
// Домашнее Задание 2
// ___________________________________________________________________________________
// Задача 10: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трёхзначное число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// int y0=x/10;
// int y1= y0 % 10;
// Console.WriteLine($"Второе число {y1}");




// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// int y0=x/100;
// int y1= y0 % 10;
// int y2= x % 10;
// int y3=x/1000;
// int y4= y3 % 10;
// if (y1 == 0 && y0 <= 0) Console.WriteLine("Третьей цифры нет ");
// else if (y4 > 0) Console.WriteLine($"Третья цифра {y1}");
// else Console.WriteLine($"Третья цифра {y2}");

// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет,
//  является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру, обозначающую день недели (Например: понедельник 1, воскресенье 7)");
// int x=Convert.ToInt32 (Console.ReadLine());
// if (x < 6) Console.WriteLine("Нет. Это не выходной");
// int y3= x2 % 10;
// else if (x == 0 || x > 7) Console.WriteLine($"цифра {x} не соответствует дню недели");

// _______________________________________________________________________________________
// ДЗ 3

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 
// 23432 -> да

Console.WriteLine("Введите число ");
int x=Convert.ToInt32 (Console.ReadLine());
int x1=x/10;
int x3=x/1000;
int x4=x/10000;
int y1= x % 10;
int y2= x1 % 10;
int y4= x3 % 10;
int y5= x4 % 10;
if (y1 == y5 && y2 == y4) Console.WriteLine("да");
else Console.WriteLine("нет");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты х точки А");
// int ax=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки А");
// int ay=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки A");
// int az=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты х точки B");
// int bx=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки B");
// int by=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки B");
// int bz=Convert.ToInt32(Console.ReadLine());

// double dist=Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2)+Math.Pow(bz-az,2));
// Console.WriteLine($"Расстояние между двумя точками равно {dist}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и
//  выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int x=Convert.ToInt32(Console.ReadLine());
// for (int i=1; i<=x; i++)
// // Console.WriteLine($"Расстояние между двумя точками равно {i}");
// Console.Write($"{i*i*i} ");
