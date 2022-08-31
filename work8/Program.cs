// Task 53.

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

// int[,] ChangeRowsInArray(int[,] array)
// {
//     int temp = 0;
//     int rows = array.GetLength(0);

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         temp = array[0, i];
//         array[0, i] = array[rows - 1, i];
//         array[rows - 1, i] = temp;
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

// int[,] array = FillArray2D(lengthMassive, heightMassive, minValue, maxValue);
// Print2dArray(array);
// System.Console.WriteLine();
// int[,] changeRowsInArray = ChangeRowsInArray(array);
// Print2dArray(changeRowsInArray);

//===============================================================================
// Task 55

// System.Console.WriteLine("Enter the length array");
// int lengthMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the height array");
// int heightMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the min number in array");
// int minValue = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the max number in array");
// int maxValue = int.Parse(Console.ReadLine());


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


// int[,] ChangeRowsAndColumns(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < array.GetLength(1); j++)
//         {
//             temp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = temp;
//         }
//     }
//     return array;
// }


// int[,] array = FillArray2D(lengthMassive, heightMassive, minValue, maxValue);
// Print2dArray(array);
// System.Console.WriteLine();

// if (lengthMassive != heightMassive)
// {
//     System.Console.WriteLine("it isn't impossible to change rows and columns");
// }
// else
// {
// int[,] changeRowsAndColuns = ChangeRowsAndColumns(array);
// Print2dArray(changeRowsAndColuns);
// }

//=====================================================================================
// Task 57

// System.Console.WriteLine("Enter the length array");
// int lengthMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the height array");
// int heightMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the min number in array");
// int minValue = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Enter the max number in array");
// int maxValue = int.Parse(Console.ReadLine());

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

// int[,] CountElements(int[,] array, int minValue, int maxValue)
// {
//     int columns = 10;
//     int [,] count = new int[2, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i,j] >= 0)
//             {
//                 count[0, array[i,j]] +=1;
//             }
//             else
//             {
//                 count[1, -array[i,j]] +=1;
//             }
//         }
        
//     }
//     return count;
// }

// void PrintResult(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//            if ( i == 0)
//            {
//             System.Console.WriteLine($"The figures {j} in an array equals {array[i,j]}");
//            } 
//            else
//            {
//             System.Console.WriteLine($"The figures {-j} in an array equals {array[i,j]}");
//            }
//         }
        
//     }
// }

// int[,] array = FillArray2D(lengthMassive, heightMassive, minValue, maxValue);
// Print2dArray(array);
// System.Console.WriteLine();

// int[,] counter = CountElements(array, minValue, maxValue);
// PrintResult(counter);

//=====================================================================================================
//Task 61

// void Print2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i,j] != 0)
//             {
//             System.Console.Write(string.Format("{0 , 3}" , array[i,j]));
//             }
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] FillTriangePascal(int rows)
// {
//     int[,] triangle = new int[rows, rows];
//     triangle[0,0] = 1;
//     triangle[1,0] = 1;
//     triangle[1,1] = 1;
//  for (int i = 2; i < rows; i++)
//     {
//         triangle[i, 0] = 1;
//         for (int j = 1; j < rows; j++)
//         {
//             triangle[i,j] = triangle[i-1, j -1] + triangle[i-1, j];
//         }
//     }
// return triangle;
// }

// System.Console.WriteLine("Enter the length array");
// int lengthMassive = int.Parse(Console.ReadLine());
// System.Console.WriteLine();

// int[,] triangle = FillTriangePascal(lengthMassive);
// Print2dArray(triangle);




