//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трёхзначное число: ");
// int input1 = Convert.ToInt32(Console.ReadLine());
// int SecondFigure(int arg)
// {
//     int result = (arg / 10) % 10;
//     return result;
// }
// int result = SecondFigure(input1);
// Console.WriteLine($"Вторая цифра: {result}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите целое число: ");
// int input2 = Convert.ToInt32(Console.ReadLine());
// int ThirdFigure(int arg)
// {
//     if (arg < 100 && arg > -100) return -1;
//     int result = 0;
//     while (arg > 1000 || arg < -1000)
//     {
//         result = arg / 10;
//         arg /= 10;
//     }
//     result %= 10;
//     if (result < 0) return result *= -1;
//     else return result;
// }
// int result = ThirdFigure(input2);
// Console.WriteLine(result);

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool IsWeekend(int arg)
// {
//     if (arg >= 6 && arg <= 7) return true;
//     return false;
// }
// Console.Write("Введите число: ");
// int input3 = Convert.ToInt32(Console.ReadLine());
// bool result = IsWeekend(input3);
// Console.WriteLine(result);