
// int[] a = {1, 2, 3, 4, 2, 6, 4, 8, 9, 14, 11, 3, 0};

// void PrintArray(int[] arr)
// {
// for(int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write($"{arr[i]} ");
// }
// }


// int[] FillArray(int[] arr)
// {
// Random random =  new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(100, 1000);

//     }
//     return arr;
// }

//--------------------------------------------------------------------------------------------------------------------

// string[,] table = new string[2, 5];


// string.empty
// table[0 , 0]   table[0 , 1]    table[0 , 2]   table[0 , 3]   table[0 , 4]
// // table[1 , 0]   table[1 , 1]    table[1 , 2]   table[1 , 3]   table[1 , 4]

// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"-{table[rows , columns]}-");
//     }
// }

//-------------------------------------------------------------------

// void PrintArray(int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         System.Console.Write($" {matr[i , j]} ");
//     }
//     System.Console.WriteLine();
// }
// }




// void FillArray(int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         matr[i, j] = new Random().Next(1, 10);
//     }
//     System.Console.WriteLine();
// }
// }

// int[,] matrix = new int[3 ,4];
// PrintArray(matrix);
// FillArray(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);


//----------------------------------------------------------------------------------------------------


// void SortArray(int[] arg) 
// {
//    Array.Reverse(arg);
//    foreach (var n in arg)
//    {
//     System.Console.Write($"{n} ");
//    }
// }

// void ReverseMethod (int[] arg)
// {
//     Array.Sort(arg);
//     foreach (var n in arg)
//    {
//     System.Console.Write($"{n} ");
//    }
// }


