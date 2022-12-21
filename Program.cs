// // Задача 21: Напишите программу, которая принимает на вход координаты двух точек (X,Y), не равные 0, 
// //и находит расстояние между ними в 3D пространстве.
// //A (3,6,8); B (2,1,-7), -> 15.84
// //A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X для первой точки");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y для первой точки");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z для первой точки");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X для второй точки");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y для второй точки");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z для второй точки");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));

// Console.WriteLine(d);

--------------------------------------------------------------------------------------------------------

// //Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// //3 -> 1, 8, 27
// //5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }

-------------------------------------------------------------------------------------------------------

// //Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// //14212 -> нет
// //12821 -> да

// Console.WriteLine("Введите пятизначное число");
// string num = Console.ReadLine();

// if (num.Length==5)
// {
//     if (num[0]==num[4] && num[1] == num[3])
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }
// else
// {
//     Console.WriteLine("Число не пятизначное");
// }