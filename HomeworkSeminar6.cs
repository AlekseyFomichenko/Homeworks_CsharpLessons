// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("введите колиство чисел: ");
// int amount = int.Parse(Console.ReadLine());
// void GetPositiveValues(int n)
// {
//     int count = 0;
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write($"Введите {i + 1} число: ");
//         int number = int.Parse(Console.ReadLine());
//         if (number > 0) count++;
//     }
//     Console.WriteLine("Количество чисел больше нуля -> " + count);
// }
// GetPositiveValues(amount);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("введите k1 и b1 через пробел: ");
// double[] kb1 = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
// Console.Write("введите k2 и b2 через пробел: ");
// double[] kb2 = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
// void GetItntersectoinPoint(double[] f1, double[] f2)
// {
//     double x = (f2[1] - f1[1]) / (f1[0] - f2[0]); //x = (b2 - b1) / (k1 - k2)
//     double y = f1[0] * x + f1[1]; //y = k1 * x + b1
//     Console.Write($"Точка пересечения двух прямых: ({x},{y})");
// }
// GetItntersectoinPoint(kb1, kb2);