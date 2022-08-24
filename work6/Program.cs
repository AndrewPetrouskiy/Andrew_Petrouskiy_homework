// task 39

// //создает массив элементов от мин до макс ----------------------------------------

// int[] GetRandomArray(int length, int minValue, int maxValue){
//     int[] array = new int[length];

//     Random random = new Random();
//     for(int i = 0; i < length; i++)
//     {
//         array[i] = random.Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// // переворачивает массив -------------------------------------------------------------

// int[] ReverseArray(int[] array)
// {
//     int[] result = new int[array.Length];

//     for(int i = 0; i< array.Length; i++)
//     {
//         result[i] = array[array.Length - 1 - i];
//     }

//     return result;
// }

// // распечатывает массив ---------------------------------------------------------------

// void PrintArray(int[] array)
// {
//      for(int i = 0; i< array.Length; i++)
//     {
//          Console.Write($"{array[i]} ");
//     }
// }


// int[] array = GetRandomArray(10, 1000, 10000);

// int[] result = ReverseArray(array);

// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Перевернутый - ");
// PrintArray(result);


//Task 40==============================================================================================



// Console.Write("Enter the first side the triangle ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second side the triangle ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the third side the triangle ");
// int c = Convert.ToInt32(Console.ReadLine());


// bool CheckTheTriangleSides(int a, int b, int c)
// {
//     if (a <= b + c && b <= a + c && c <= a + b)
//     {
//         return true;
//     }
//     return false;
// }

// bool result = CheckTheTriangleSides(a , b, c);
// if (result == true)
// {
//     System.Console.WriteLine($"The triange with sides a =  {a}, b =  {b}, c =  {c}  exists");
// } 
// else
// {
// System.Console.WriteLine($"The triange with sides a =  {a}, b =  {b}, c =  {c} doesn't exists");
// }

// Task 42 =======================================================

//solution 1-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

// string TranslateTheNumber( int n)
// {
//    string num = String.Empty;
//    while(n>0)
//    {
//       num = num + n % 2;
//       n = n /2;
//    }
//    return num;
// }

// char[] ReverseArray(string num)
// {
//    char[] result = new char[num.Length];
//    for (int i = 0; i < num.Length; i++)
//    {
//       result[i] = num[num.Length - 1 - i];
//    }
//    return result;
// }

// void PrintArray(char[] array)
// {
//      for(int i = 0; i< array.Length; i++)
//     {
//          Console.Write($"{array[i]}");
//     }
// }

// Console.Write("Enter the Number ");
// int number = Convert.ToInt32(Console.ReadLine());

// string result = TranslateTheNumber(number);
// System.Console.WriteLine($"Reverse binar number of number {number} = {result}");
// char[] reverseResult = ReverseArray(result);
// PrintArray(reverseResult);


//solution 2 -=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

// Console.Write("Enter the Number ");
// int number = Convert.ToInt32(Console.ReadLine());


// // string binary = Convert.ToString(number, 2); - метод который переводит в 2, 8 , 10 и 16 систему.
// // System.Console.WriteLine(binary);

// string Binary(int num)
// {
//    string str = String.Empty;
//    while (num > 0)
//    {
//       str = $"{Convert.ToString(num%2)}{str}";
//       num = num / 2;
//    }
//    return str;
// }

// System.Console.WriteLine(Binary(number));

// Task 44 =====================================================================

// int[,] array2d = new int [10 , 10];

// Random random = new Random();

// for (int i = 0; i < array2d.GetLength(0); i++)
// {
//    for (int j = 0; j < array2d.GetLength(1); j++)
//    {
//       array2d[i,j] = random.Next(10 , 100);
//    }
// }

// void Print2dArray(int[,] array)
// {
//    for (int i = 0; i < array2d.GetLength(0); i++)
// {
//    for (int j = 0; j < array2d.GetLength(1); j++)
//    {
//       System.Console.Write($"{array2d[i , j]} ");
//    }
//    System.Console.WriteLine();
// }
// }

// Print2dArray(array2d);

// System.Console.WriteLine();
// System.Console.WriteLine();

// int[,] CopyArray2D(int[,] array)
// {
//    int[,] copyArr = new int [10, 10];

//    for (int i = 0; i < array.GetLength(0); i++)
// {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//       copyArr[i,j] = array[i , j];
//    }
// }
// return copyArr;
// }
// Print2dArray(CopyArray2D(array2d));