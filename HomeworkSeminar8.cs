// int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     Random random = new Random();
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < colums; j++)
//             array[i, j] = random.Next(minValue, maxValue + 1);
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// void BubbleSort(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         for (int j = 0; j < arr.Length - 1; j++)
//             if (arr[j] < arr[j + 1])
//                 (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
// }
// void BubbleSort2dArray(int[,] array)
// {
//     int[] row = new int[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             row[j] = array[i, j];
//         BubbleSort(row);
//         for (int k = 0; k < array.GetLength(1); k++)
//             array[i, k] = row[k];
//     }
// }
// void QuickSort(int[] array, int start, int end)
// {
//     if (end == start) return;
//     int pivot = array[end];
//     int wall = start;
//     for (int i = start; i < end; i++)
//         if (array[i] >= pivot)
//         {
//             (array[i], array[wall]) = (array[wall], array[i]);
//             wall++;
//         }
//     (array[wall], array[end]) = (array[end], array[wall]);
//     if (wall > start) QuickSort(array, start, wall - 1);
//     if (wall < end) QuickSort(array, wall + 1, end);
// }
// void QuickSort2dArray(int[,] array)
// {
//     int[] row = new int[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             row[j] = array[i, j];
//         QuickSort(row, 0, row.Length - 1);
//         for (int k = 0; k < array.GetLength(1); k++)
//             array[i, k] = row[k];
//     }
// }
// int[] temporaryArray;
// void Merge(int[] array, int start, int middle, int end)
// {
//     var leftPtr = start;
//     var rightPtr = middle + 1;
//     var length = end - start + 1;
//     for (int i = 0; i < length; i++)
//     {
//         if (rightPtr > end || (leftPtr <= middle && array[leftPtr] > array[rightPtr]))
//         {
//             temporaryArray[i] = array[leftPtr];
//             leftPtr++;
//         }
//         else
//         {
//             temporaryArray[i] = array[rightPtr];
//             rightPtr++;
//         }
//     }
//     for (int i = 0; i < length; i++)
//         array[i + start] = temporaryArray[i];
// }
// void MergeSort(int[] array, int start, int end)
// {
//     if (start == end) return;
//     var middle = (start + end) / 2;
//     MergeSort(array, start, middle);
//     MergeSort(array, middle + 1, end);
//     Merge(array, start, middle, end);

// }
// void MergeSort1(int[] array)
// {
//     temporaryArray = new int[array.Length];
//     MergeSort(array, 0, array.Length - 1);
// }
// void MergeSort2dArray(int[,] array)
// {
//     int[] row = new int[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             row[j] = array[i, j];
//         MergeSort1(row);
//         for (int k = 0; k < array.GetLength(1); k++)
//             array[i, k] = row[k];
//     }
// }
// Console.WriteLine("MergeSort:\n");
// int[,] inputArray = CreateRandom2dArray(4, 4, 10, 100);
// Show2dArray(inputArray);
// MergeSort2dArray(inputArray);
// Show2dArray(inputArray);
// Console.WriteLine("QuickSort:\n");
// int[,] arr = CreateRandom2dArray(4, 4, 10, 100);
// Show2dArray(arr);
// QuickSort2dArray(arr);
// Show2dArray(arr);
// Console.WriteLine("BubbleSort:\n");
// int[,] arr1 = CreateRandom2dArray(4, 4, 10, 100);
// Show2dArray(arr1);
// BubbleSort2dArray(arr1);
// Show2dArray(arr1);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// void GetMinSumOfRow(int[,] myArray)
// {
//     int[] sum = new int[myArray.GetLength(0)];
//     for (int i = 0; i < myArray.GetLength(0); i++)
//         for (int j = 0; j < myArray.GetLength(1); j++)
//             sum[i] += myArray[i, j];
//     int indexOfMinValue = Array.IndexOf(sum, sum.Min());
//     Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexOfMinValue + 1}.\n");
// }
// int[,] arr2 = CreateRandom2dArray(4, 10, 0, 100);
// Console.WriteLine("Найти строку с наименьшей суммой:\n");
// Show2dArray(arr1);
// GetMinSumOfRow(arr1);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4        2*3+4*3 2*4+4*3
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// int[,] GetProductMatrix(int[,] array1, int[,] array2)
// {
//     if (array1.GetLength(0) != array2.GetLength(1) ||
//         array1.GetLength(1) != array2.GetLength(0)) return new int[0, 0];
//     else
//     {
//         int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
//         for (int i = 0; i < array1.GetLength(0); i++)
//             for (int j = 0; j < array2.GetLength(1); j++)
//                 for (int k = 0; k < array1.GetLength(1); k++)
//                     newArray[i, j] += array1[i, k] * array2[k, j];
//         return newArray;
//     }
// }
// int[,] matrix1 = CreateRandom2dArray(2, 2, 0, 10);
// int[,] matrix2 = CreateRandom2dArray(2, 2, 0, 10);
// Console.WriteLine("Произведение двух матриц:");
// Show2dArray(matrix1);
// Show2dArray(matrix2);
// Console.WriteLine("Результирующая матрица:");
// int[,] product = GetProductMatrix(matrix1, matrix2);
// Show2dArray(product);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// int[,,] superArray =
// {
//     {
//         {78, 56},
//         {59, 81}
//     },
//     {
//         {25, 47},
//         {94, 38}
//     }
// };
// Console.WriteLine("Вывод трехмерного массива:\n");
// void Show3dArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         Console.WriteLine($"{i + 1}-й слой:");
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             Console.WriteLine();
//         }
//     }
// }
// Show3dArray(superArray);


// Задача 62. Напишите программу, которая заполнит спирально любой двумерный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
