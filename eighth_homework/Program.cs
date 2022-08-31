// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] FillArray2D(int lengthMassive, int heightMassive, int minValue, int maxValue)
// {
//     int[,] array = new int[lengthMassive, heightMassive];

//     Random random = new Random();

//     for (int i = 0; i < lengthMassive; i++)
//     {
//         for (int j = 0; j < heightMassive; j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// int [,] SortArray(int[,] array)
// {
// int temp = 0;
// for (int k = 0; k < array.GetLength(0); k++)
// {
//     for (int i = 0; i < array.GetLength(1) - 1; i++)
//     {
//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             if (array[k,i] > array[k,j])
//             {
//                 temp = array[k,i];
//                 array[k,i] = array[k,j];
//                 array[k,j] = temp;
//             }
//         }
//     }
// }
// return array;
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

// int[,] ReverseArray(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, columns - j - 1] = array[i, j];
//         }
//     }
//     return result;
// }

// System.Console.WriteLine("Enter the length array");
// int lengthMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the height array");
// int heightMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the min number in array");
// int minValue = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the max number in array");
// int maxValue = int.Parse(Console.ReadLine());

// int[,] fillArray = FillArray2D(lengthMassive, heightMassive, minValue, maxValue);
// Print2dArray(fillArray);
// System.Console.WriteLine();
// int[,] sortArray = SortArray(fillArray);
// int[,] reverseArray = ReverseArray(sortArray);
// Print2dArray(reverseArray);

//==================================================================================================================================
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.



// int[,] FillArray2D(int lengthMassive, int heightMassive, int minValue, int maxValue)
// {
//     int[,] array = new int[lengthMassive, heightMassive];

//     Random random = new Random();

//     for (int i = 0; i < lengthMassive; i++)
//     {
//         for (int j = 0; j < heightMassive; j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue);
//         }
//     }
//     return array;
// }


// int[] CalculateSumNumberInRows(int[,] array, int lengthMassive)
// {
//     int[] sumRows = new int[lengthMassive];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumRows[i] += array[i, j];
//         }

//     }
//     return sumRows;
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

// void PrintArray(int[] arr)
// {

//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }

// }

// void PrintArray2(int[] arr)
// {
//     int min = int.MaxValue;
//     int index = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] < min)
//         {
//             min = arr[i];
//             index = i+1;
//         }

//     }
//     System.Console.WriteLine($"The row with the smallest sum of elements is {index} and this sum equal {min}");
// }

// System.Console.WriteLine("Enter the length array");
// int lengthMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the height array");
// int heightMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the min number in array");
// int minValue = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the max number in array");
// int maxValue = int.Parse(Console.ReadLine());

// if(heightMassive == lengthMassive)
// {
//     System.Console.WriteLine("The Matrix isn't rectangular. Try again");
// }
// else
// {
// int[,] Matrix = FillArray2D(lengthMassive, heightMassive, minValue, maxValue);
// Print2dArray(Matrix);
// int[] sumRows = CalculateSumNumberInRows(Matrix, lengthMassive);
// PrintArray(sumRows);
// System.Console.WriteLine();
// PrintArray2(sumRows);
// }

//==============================================================================================================
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] FillArray2D(int lengthMassive, int heightMassive, int minValue, int maxValue)
// {
//     int[,] array = new int[lengthMassive, heightMassive];

//     Random random = new Random();

//     for (int i = 0; i < lengthMassive; i++)
//     {
//         for (int j = 0; j < heightMassive; j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue);
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

// int[,] MultiplyMatrixes(int[,] Matrix, int[,] MatrixTwo)
// {
// int[,] array= new int[Matrix.GetLength(0), Matrix.GetLength(1)];
//     int j = 0;
//     for (int i = 0; i < Matrix.GetLength(0); i++)
//     {
//         for (j = 0; j < Matrix.GetLength(0); j++)
//         {
//             array[i, j] = Matrix[i, j] * MatrixTwo[i, j];
//         }

//     }
//     return array;
// }

// System.Console.WriteLine("Enter the length array");
// int lengthMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the height array");
// int heightMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the min number in array");
// int minValue = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the max number in array");
// int maxValue = int.Parse(Console.ReadLine());

// int[,] matrix = FillArray2D(lengthMassive, heightMassive, minValue, maxValue);
// System.Console.WriteLine("The first matrix equals");
// Print2dArray(matrix);
// System.Console.WriteLine();
// int[,] matrixTwo = FillArray2D(lengthMassive, heightMassive, minValue, maxValue);
// System.Console.WriteLine("The second matrix equals");
// Print2dArray(matrixTwo);
// System.Console.WriteLine();
// int[,] matrixThree = MultiplyMatrixes(matrix, matrixTwo);
// System.Console.WriteLine("The multiply of two matrixes equals");
// Print2dArray(matrixThree);

//=================================================================================================
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] FillArray3D(int lengthArray, int heightArray, int depthArray, int minValue, int maxValue)
// {
//     var rnd = new Random();
//     var set = new HashSet<int>();
//     int[,,] arr = new int[lengthArray, heightArray, depthArray];
//     for (int i = 0; i < lengthArray; i++)
//     {
//         for (int j = 0; j < heightArray; j++)
//         {
//             for (int k = 0; k < depthArray; k++)
//             {
//                 int rand;
//                 do
//                 {
//                     rand = rnd.Next(minValue, maxValue);
//                 } 
//                 while (set.Contains(rand));
//                 set.Add(rand);
//                 arr[i, j, k] = rand;
//             }
//         }

//     }
//     return arr;
// }

// void Print3DMatrix(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 System.Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             System.Console.WriteLine();
//         }
//     }
// }

// System.Console.WriteLine("Enter the length array");
// int lengthArray = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the height array");
// int heightArray = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the depth array");
// int depthArray = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the min number in array");


// int[,,] Matrix3D = FillArray3D(lengthArray, heightArray, depthArray, 10, 100);
// Print3DMatrix(Matrix3D);


//================================================================================================
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] CreateSpiralMatrix(int n)
{
    int[,] result = new int[n, n];

    int pos = 0;
    int count = n;
    int value = -n;
    int sum = -1;

    do
    {
        value = -1 * value / n;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }
    } while (count > 0);

    return result;
}



void PrintArray(int[,] array)
{
    int n = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString().PadLeft(n, ' '));
        }
        Console.WriteLine();
    }
}

System.Console.WriteLine("Enter the size of spiral matrix");
int sizeSpiralMatrix = int.Parse(Console.ReadLine());

int[,] result = CreateSpiralMatrix(sizeSpiralMatrix);
System.Console.WriteLine("The spiral of matrix created");
PrintArray(result);


