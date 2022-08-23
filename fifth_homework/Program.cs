// void PrintArray(int[] arr)
// {
// for(int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write($"{arr[i]} ");
// }
// }


//-----------------------------------------------------------------------------------------------------------------------
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] array = new int[10];

// int[] FillArray(int[] arr)
// {
// Random random =  new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(100, 1000);

//     }
//     return arr;
// }


int ShowEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// int[] fill = FillArray(array);
// int countEvenNum = ShowEvenNumbers(fill);
// Console.Write($"The {countEvenNum} even numbers have between ");
// PrintArray(fill);



//--------------------------------------------------------------------------------------------------------------------------
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] array = new int[8];

// int[] FillArray(int[] arr)
// {
// Random random =  new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(0 , 1000);
//     }
//     return arr;
// }


int FindSumOddPositionsNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

// int[] fill = FillArray(array);
// int sumOdd = FindSumOddPositionsNumbers(fill);
// System.Console.Write($"The sum odd position numbers = {sumOdd} in massive ");
// PrintArray(fill);

//---------------------------------------------------------------------------------------------------------------------
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//SOLUTION 1. тут я искал через вложенный цикл


// int[] array = new int[10];

// int[] FillArray(int[] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(-1000, 1000);
//     }
//     return arr;
// }


// int FindDIfferenceBetweeMaxAndMin(int[] arr)
// {
//     int min = int.MaxValue;
//     int max = int.MinValue;
//     foreach (var item in arr)
//     {
//         if (item > max)
//         {
//             max = item;
//         }
//         foreach (var item2 in arr)
//         {
//             if (item2 < min)
//             {
//                 min = item2;
//             }
//         }
//     }

//     int difference = max - min;
//     return difference;
// }

// int[] fill = FillArray(array);
// int difference = FindDIfferenceBetweeMaxAndMin(fill);
// System.Console.Write($"{difference} it's a difference between max and min meaning of massive ");
// PrintArray(fill);



//---------------------------------------------------------------------------------------------------------------
// SOLUTION 2.  тут я делал 3 метода. где я отдельно нашел min , max и разницу.

// int[] array = new int[4];

// int[] FillArray(int[] arr)
// {
// Random random =  new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(-1000 , 1000);
//     }
//     return arr;
// }


// int FindMax(int[] arr)
// {

//     int max = int.MinValue;
//     foreach (var item in arr)
//     {
//       if(item > max)
//        {
//         max = item;
//        }  
//     }

//     return max;
// }

// int FindMin(int[] arr)
// {

//     int min = int.MaxValue;
//     foreach (var item in arr)
//     {
//       if(item < min)
//        {
//         min = item;
//        }  
//     }

//     return min;
// }

// int FindDIfferenceBetweeMaxAndMin(int max , int min)
// {
//     int difference = max - min;
//     return difference;
// }

// int[] fill = FillArray(array);
// int max = FindMax(fill);
// System.Console.WriteLine($"Max = {max}");
// int min = FindMin(fill);
// System.Console.WriteLine($"Min = {min}");
// System.Console.WriteLine();
// int difference = FindDIfferenceBetweeMaxAndMin(max , min);
// System.Console.Write($"{difference} it's a difference between  max ={max} and min = {min} in massive ");
// PrintArray(fill);



//-----------------------------------------------------------------------------------------------------------------------
// Solution 3 . Тут я попробывал через дробные числа.

double[] array = new double[4];

double[] FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(random.Next(-10 , 11) * random.NextDouble(), 2);
    }
    return arr;
}


void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}



double FindDIfferenceBetweeMaxAndMin(double[] arr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    foreach (var item in arr)
    {
        if (item > max)
        {
            max = item;
        }
        foreach (var item2 in arr)
        {
            if (item2 < min)
            {
                min = item2;
            }
        }
    }

    double difference = max - min;
    return difference;
}

double[] fill = FillArray(array);
double difference = Math.Round(FindDIfferenceBetweeMaxAndMin(fill), 2, MidpointRounding.AwayFromZero);
System.Console.Write($"{difference} it's a difference between max and min meaning of massive ");
PrintArray(fill);


