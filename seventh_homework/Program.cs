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

// int[,] FillArray2D(int m, int n, int minValue, int maxValue)
// {
//     int[,] array = new int[m, n];

//     Random random = new Random();

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
    
// }

// void Print2dArray(int[,] array)
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

// int[] CheckTheNumberInArray(int[,] arr, int number)
// {

    
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (number == arr[i, j])
//             {
//                int[] array = {i , j};
//                return array;
//             }
            
//         }
//     }
//     return null;
// }

// System.Console.WriteLine("Enter the length number");
// int lengthMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the higher number");
// int higherMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the min number");
// int minValue = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the max number");
// int maxValue = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Enter the number which you want to find in the array");
// int number = int.Parse(Console.ReadLine());

// int[,] array = FillArray2D(lengthMassive, higherMassive, minValue, maxValue);
// Print2dArray(array);
// System.Console.WriteLine();
// int[] index = CheckTheNumberInArray(array , number);

// if (index == null)
// {
//     System.Console.WriteLine($"The number {number} doesn't exist in this array");
// }
// else
// {
//     System.Console.Write($"The number {number} is in array under indexes" );
//     PrintArray(index);
// }

//===========================================================================================================
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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

void PrintArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    
}

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(string.Format("{0,5}", array[i , j]));
        }
        System.Console.WriteLine();
    }
}


int[] CalculateSumNumberInColumn(int[,] array, int lengthMassive)
{
    int[] sumColumn = new int[lengthMassive];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumColumn[i] += array[j, i];
        }
        
    }
    return sumColumn;
}

void CalculateAverageNumberInColumn(int[] array, int lengthMassive)
{
int[] avrColumn = new int[lengthMassive];
    foreach (double element in array)
    {
        System.Console.Write($"{element / lengthMassive}; "); 
    }
}

System.Console.WriteLine("Enter the length number");
int lengthMassive = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the higher number");
int higherMassive = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the min number");
int minValue = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the max number");
int maxValue = int.Parse(Console.ReadLine());

int[,] array = FillArray2D(lengthMassive, higherMassive, minValue, maxValue);
Print2dArray(array);
System.Console.WriteLine();
int[] sumColumn = CalculateSumNumberInColumn(array, lengthMassive);
System.Console.Write("The sum of wich column in the array equals  ");
PrintArray(sumColumn);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.Write("The average of columns in the array is equals  ");
CalculateAverageNumberInColumn(sumColumn, lengthMassive);
