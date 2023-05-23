// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2dArray(int m, int n)
// {
//     double[,] arr = new double[m, n];
//     for (int i = 0; i < m; i++)
//         for (int j = 0; j < n; j++)
//             arr[i, j] = new Random().Next(1, 10) + Math.Round(new Random().NextDouble(), 1);
//     return arr;
// }
// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// double[,] newArray = Create2dArray(3, 4);
// Show2dArray(newArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

// void GetValue(double[,] array, int index1, int index2)
// {
//     if (index1 >= array.GetLength(0) || index2 >= array.GetLength(1) || index1 < 0 || index2 < 0) Console.WriteLine("Такого элемента нет.");
//     else Console.WriteLine($"Значение индекса [{index1},{index2}] = " + array[index1, index2]);
// }
// double[,] newArray2 = Create2dArray(3, 4);
// Show2dArray(newArray2);
// GetValue(newArray2, 2, 3);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < colums; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }
// double[] ArithmeticMean(int[,] array)
// {
//     double[] result = new double[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//             result[i] += array[j, i];
//         result[i] = Math.Round(result[i] / array.GetLength(0), 1);
//     }
//     return result;
// }
// int[,] newArray3 = CreateRandom2dArray(3, 4, 1, 10);
// ShowArray(newArray3);
// double[] arithmeticMean = ArithmeticMean(newArray3);
// for (int i = 0; i < arithmeticMean.Length; i++)
// {
//     Console.WriteLine(arithmeticMean[i]);
// }
