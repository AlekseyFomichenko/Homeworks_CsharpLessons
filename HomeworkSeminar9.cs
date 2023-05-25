// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void ShowNums(int N)
{
    Console.Write("{0,-5}", N);
    if (N > 1) ShowNums(N - 1);
}
ShowNums(8);
Console.WriteLine();


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int GetIntSum(int m, int n) => m < n ? m + GetIntSum(m + 1, n) : (m > n ? m + GetIntSum(m - 1, n) : n);

Console.WriteLine(GetIntSum(1, 15));
Console.WriteLine(GetIntSum(15, 1));
Console.WriteLine(GetIntSum(8, 4));
Console.WriteLine(GetIntSum(4, 8));
Console.WriteLine(GetIntSum(-1, 5));
Console.WriteLine(GetIntSum(5, -1));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ackermann(int m, int n)
// {
//     if(m == 0) return n + 1;
//     if(n == 0) return Ackermann(m - 1, 1);
//     return Ackermann(m - 1, Ackermann(m, n - 1 ));
// }
int Ackermann(int m, int n) => m == 0 ? n + 1 : (n == 0 ? Ackermann(m - 1, 1) : Ackermann(m - 1, Ackermann(m, n - 1)));

Console.WriteLine(Ackermann(2, 3));
Console.WriteLine(Ackermann(3, 2));