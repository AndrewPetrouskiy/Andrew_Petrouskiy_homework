//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] FillArray2D(int m, int n, int minValue, int maxValue)
// {
//     double[,] array = new double[m, n];

//     Random random = new Random();

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = Math.Round(random.Next(minValue, maxValue) * random.NextDouble(), 1);
//         }
//     }
//     return array;
// }

// void Print2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Enter the length number");
// int lengthMassive = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Enter the higher number");
// int higherMassive = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Enter the min number");
// int minValue = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Enter the max number");
// int maxValue = int.Parse(Console.ReadLine());

// double[,] result = FillArray2D(lengthMassive, higherMassive, minValue, maxValue);
// System.Console.WriteLine();
// System.Console.WriteLine("Outputting the real numbers to the console");
// System.Console.WriteLine();
// Print2dArray(result);

//============================================================================================
//Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
//и возвращает индексы этого элемента или же указание, что такого элемента нет.

int[,] FillArray2D(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minValue, maxValue);
        }
    }
    return array;
}


void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

string CheckTheNumberInArray(int[,] arr, int number)
{

    string indexes = string.Empty;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (number == arr[i, j])
            {
                indexes = indexes + i + "," + j+ ";  ";
            }
        }
    }
    return indexes;
}

System.Console.WriteLine("Enter the length number");
int lengthMassive = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the higher number");
int higherMassive = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the min number");
int minValue = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the max number");
int maxValue = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter the number which you want to find in the array");
int number = int.Parse(Console.ReadLine());

int[,] array = FillArray2D(lengthMassive, higherMassive, minValue, maxValue);
Print2dArray(array);
System.Console.WriteLine();
string indexes = CheckTheNumberInArray(array , number);

if (indexes == string.Empty)
{
    System.Console.WriteLine($"The number {number} doesn't exist in this array");
}
else
{
    System.Console.WriteLine($"The number {number} is in array under indexes {indexes}");
}

