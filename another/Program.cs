//вввести с консоли число.

// Console.Write("Enter the number ");
// int input = Convert.ToInt32(Console.ReadLine());

//---------------------------------------------------------------------

//печатать массив

// void PrintArray(int[] arr)
// {
// for(int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write($"{arr[i]} ");
// }
// }
//-----------------------------------------------------------------------

// заполнить массив

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

//вывести двумерный массив string


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

//вывести двумерный массив.

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


//--------------------------------------------------------------------------

//заполнение двумерного массива числами.

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


//----------------------------------------------------------------------------------------------------

// сортировать массив.


// void SortArray(int[] arg) 
// {
//    Array.Reverse(arg);
//    foreach (var n in arg)
//    {
//     System.Console.Write($"{n} ");
//    }
// }

//----------------------------------------------------------

// перевернуть массив.

// void ReverseMethod (int[] arg)
// {
//     Array.Sort(arg);
//     foreach (var n in arg)
//    {
//     System.Console.Write($"{n} ");
//    }
// }

// метод перевернуть массив.

// int[] ReverseArray(int[] array)
// {
//     int[] result = new int[array.Length];

//     for(int i = 0; i< array.Length; i++)
//     {
//         result[i] = array[array.Length - 1 - i];
//     }

//     return result;
// }


// ----------------------------------------------------------------------------

//поиск триплетов.

// int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };


// for (int i = 0; i < numbers.Length - 2; i++)
// {
//     for (int j = i + 1; j < numbers.Length; j++)
//     {
//         for (int k = j + 1; k < numbers.Length; k++)
//         {
//             int atI = numbers[i];
//             int atJ = numbers[j];
//             int atK = numbers[k];
//             if (atI + atJ + atK == 0)
//             {
//                 Console.WriteLine($"Pair ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
//             }
//         }

//     }
// }

//--------------------------------------------------------------------------

    
//поиск фибаначчи без рекурсии.

// Console.WriteLine("enter the number of fibanacci numbers");
// int n = int.Parse(Console.ReadLine());

// int[] fibanacci = new int[n];

// int a0 = 0;
// int a1 = 1;


// fibanacci[0] = a0;
// fibanacci[1] = a1;

// for (int i = 2; i < n; i++)
// {
//    int a = a0 + a1;
//    fibanacci[i] = a;

//    a0 = a1;
//    a1 = a;
// }
// foreach (int cur in fibanacci)
// {
//    Console.WriteLine(cur);
// }
// Console.ReadLine();



// Проверка число ли мы ввели
//------------------------------------------------

// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

// if(isNumberM == false || isNumberN == false)
// {
//     System.Console.WriteLine("Введены неправильные данные.");
//     return;
// }



// проверка затрачиваемого времени
//==============================================================================

// DateTime saveTime;
// Console.WriteLine($"Цикл for: ");
// saveTime = DateTime.Now;
// - задание времени


// Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");
// - вывод затрачиваемого времени




// Проверка, быстрого и медленного фибаначчи
//====================================================================================================


/*double FibonacciBad(int n)
{
    if (n == 1 || n == 2) return 1;
    else return FibonacciBad(n - 1) + FibonacciBad(n - 2);
}
double FibonacciR(double[] f, int n)
{
    if (n == 1 || n == 2)
    {
        return f[n - 1] = 1;
    }
    else
    {
        if (f[n - 2] != 0)
        {
            if (f[n - 1] != 0)
                return f[n - 1] = f[n - 2] + f[n - 3];
            else
                return f[n - 1] = FibonacciR(f, n - 1) + f[n - 3];
        }
        else
            return f[n - 1] = FibonacciR(f, n - 1) + FibonacciR(f, n - 2);
    }
}
double FibonacciGood(int n)
{
    double[] f = new double[n];
    return FibonacciR(f, n);
}
int countTests = 40;
DateTime saveTime;
Console.WriteLine($"Цикл for: ");
saveTime = DateTime.Now;
int fibonacci1 = 1;
int fibonacci2 = 1;
for (int i = 1; i <= countTests; i++)
{
    Console.WriteLine($"f({i}) = {fibonacci2}");
    int temporary = fibonacci2;
    fibonacci2 += fibonacci1;
    fibonacci1 = temporary;
}
Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");
Console.WriteLine($"FibonacciBad: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{
    Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
}
Console.WriteLine($"Для FibonacciBad прошло: {DateTime.Now - saveTime}");
Console.WriteLine($"FibonacciGood: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{
    Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
}
Console.WriteLine($"Для FibonacciR прошло: {DateTime.Now - saveTime}");*/











