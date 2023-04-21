// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int CountEvens(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] newArray = CreateRandomArray(20, 100, 999);
ShowArray(newArray);
Console.WriteLine(CountEvens(newArray));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int SumUneven(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}
int[] newArray2 = CreateRandomArray(6, 1, 5);
ShowArray(newArray2);
Console.WriteLine(SumUneven(newArray2));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] InputArray()
{
    Console.Write("Введите количество элементов в массиве: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] myArray = new double[size];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите значение индекса {i}: ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return myArray;
}
double Spread(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];
        else if (array[i] > maxValue) maxValue = array[i];
    }
    return Math.Round(maxValue - minValue, 2);
}
void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double[] newArray3 = InputArray();
ShowDoubleArray(newArray3);
Console.WriteLine(Spread(newArray3));
//_________________________________________________________
double Spread2(double[] array)
{
    return Math.Round(array.Max() - array.Min(), 2);
}
double[] newArray4 = InputArray();
ShowDoubleArray(newArray4);
Console.WriteLine(Spread2(newArray4));