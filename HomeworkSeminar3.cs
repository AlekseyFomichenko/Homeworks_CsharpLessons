// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да 

// bool IsPalindrome(int arg)
// {
//     if (arg < 0) arg *= -1;
//     int number = arg;
//     int palindrome = 0;
//     while (number > 0)
//     {
//         palindrome *= 10;
//         palindrome += number % 10;
//         number /= 10;
//     }
//     if (arg == palindrome) return true;
//     else return false;
// }
// Console.Write("Введите число: ");
// int input = Convert.ToInt32(Console.ReadLine());
// bool result = IsPalindrome(input);
// Console.WriteLine(result);

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// static double SegmentDistance(double[] a, double[] b)
// {
//     return Math.Round(Math.Sqrt((b[0] - a[0]) * (b[0] - a[0]) +
//                                 (b[1] - a[1]) * (b[1] - a[1]) +
//                                 (b[2] - a[2]) * (b[2] - a[2])), 2);
// }
// Console.Write("Введите через пробел координаты первой точки: ");
// double[] pointA = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
// Console.Write("Введите через пробел координаты второй точки: ");
// double[] pointB = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
// double lineAB = SegmentDistance(pointA, pointB);
// Console.WriteLine(lineAB);

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

static void TableOfCubes(int n)
{
    int current = 1;
    while (current <= n)
    {
        Console.WriteLine($"{current}\t{Math.Pow(current, 3)}\n");
        current++;
    }
}
Console.Write("Введите число: ");
int userInput = Convert.ToInt32(Console.ReadLine());
TableOfCubes(userInput);