// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

// if(isNumberM == false || isNumberN == false)
// {
//     System.Console.WriteLine("Введены неправильные данные.");
//     return;
// }

// int[,] FillArray2D(int m, int n, int minValue, int maxValue)
// {
//     int[,] array = new int[m,n];

// Random random = new Random();

//     for(int i = 0; i <m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i,j] = random.Next(minValue , maxValue);
//         }
//     }
//     return array;
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

// int[,] result = FillArray2D(m , n , 1, 11);
// Print2dArray(result);



// Task 48---------------------------------------------------------------------------------------



// System.Console.WriteLine("Enter the length of massive");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// System.Console.WriteLine("Enter the higher of massive");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

// if(isNumberM == false || isNumberN == false)
// {
//     System.Console.WriteLine("Введены неправильные данные.");
//     return;
// }


// int[,] FillArray2D(int m, int n)
// {
//     int[,] array = new int[m,n];

//     for(int i = 0; i <m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i,j] = i + j;
//         }
//     }
//     return array;
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

// int[,] result = FillArray2D(m , n);
// Print2dArray(result);



// Task 50---------------------------------------------------------------------------------------


// System.Console.WriteLine("Enter the length of massive");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// System.Console.WriteLine("Enter the higher of massive");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

// if (isNumberM == false || isNumberN == false)
// {
//     System.Console.WriteLine("Введены неправильные данные.");
//     return;
// }

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

// int[,] ChangeNumberInSquare(int[,] array)
// {

//     for (int i = 0; i < m; i += 2)
//     {
//         for (int j = 0; j < n; j += 2)
//         {
//             // if(i % 2 == 0 && j % 2 == 0)
//             // {
//             array[i, j] = array[i, j] * array[i, j];
//             // }
//         }
//     }
//     return array;
// }


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



// int[,] result = FillArray2D(m, n, 5, 15);
// Print2dArray(result);
// Console.WriteLine();
// int[,] array2d = ChangeNumberInSquare(result);
// Print2dArray(array2d);


// Task 52


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

int FindSummElementsInMassive2(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}


int FindSummElementsInMassive(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        sum = sum + array[i, i];
    }
    return sum;
}



System.Console.WriteLine("Enter the length number");
int numberFirst = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the higher number");
int numberSecond = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the min number");
int minValue = int.Parse(Console.ReadLine());
System.Console.WriteLine("Enter the max number");
int maxValue = int.Parse(Console.ReadLine());

int[,] array = FillArray2D(numberFirst, numberSecond, minValue, maxValue);
Print2dArray(array);
System.Console.WriteLine();
if (numberFirst == numberSecond)
{
    int sum = FindSummElementsInMassive(array);
    System.Console.WriteLine($"The sum = {sum}");
}
else
{
    int sum = FindSummElementsInMassive2(array);
    System.Console.WriteLine($"The sum = {sum}");
}





























// int[,] array = new int[10, 10];



// Random random = new Random();

// for (int i = 0; i < array2d.GetLength(0); i++)
// {
//     for (int j = 0; j < array2d.GetLength(1); j++)
//     {
//         array[i, j] = random.Next(10, 100);
//     }
// }



// void Print2dArray(int[,] array)
// {
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             System.Console.Write($"{array2d[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] ChangeNumberInSquare(int[,] array)
// {
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2== 0)
//             {
//                 array[i , j] = array[i , j] * array[i , j];
//             }

//         }
//     }
//     return array;
// }
// Print2dArray(array);
// System.Console.WriteLine();
// int[,] array2d = ChangeNumberInSquare(int [,] array);
// Print2dArray(array2d);


