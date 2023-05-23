// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// int Exponentiation(int number, int power)
// {
//     if (power == 0) return 1;
//     return number * Exponentiation(number, Math.Abs(power) - 1);
// }
// Console.WriteLine(Exponentiation(2, -10));

// int Exponentiation_2(int number, int power)
// {
//     int result = 1;
//     for (int i = 0; i < Math.Abs(power); i++)
//         result *= number;
//     return result;
// }
// Console.WriteLine(Exponentiation_2(2, -10));

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// // 452 -> 11

// // 82 -> 10

// // 9012 -> 12

// int SumOfDigits(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number /= 10;
//     }
//     return result;
// }
// Console.WriteLine(SumOfDigits(9012));

// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// // 6, 1, 33 -> [6, 1, 33]

// int[] myArray = { 5, 8, 34, 67, 52, 970, 658, 17 };
// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write($"{myArray[i]} ");
// }
// Console.WriteLine();
// //________________________________________________________________________
// void PrintRandomArray(int countOfIndex)
// {
//     var random = new Random();
//     int[] randomArray = new int[countOfIndex];
//     for (int i = 0; i < randomArray.Length; i++)
//     {
//         randomArray[i] = random.Next(100);
//         Console.Write($"{randomArray[i]} ");
//     }
//     Console.WriteLine();
// }
// PrintRandomArray(8);
// Console.WriteLine();
// //________________________________________________________________________
// int[] InputArray(int countOfIndex)
// {
//     int[] myArray2 = new int[countOfIndex];
//     for (int i = 0; i < myArray2.Length; i++)
//     {
//         Console.Write($"Введите значение индекса {i}: ");
//         myArray2[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return myArray2;
// }
// int[] newArray = InputArray(8);
// Console.WriteLine();
// for (int i = 0; i < newArray.Length; i++)
// {
//     Console.Write($"{newArray[i]} ");
// }

