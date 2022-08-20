//Заполнение массива.

// int[] array = new int[8];

// int[] FillArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);

//     }
//     return arr;
// }



//.....................................



// int[] FillArray(int[] arr)
// {
// Random random =  new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(0, 2);

//     }
//     return arr;
// }



// Распечатать массив

// void PrintArray(int[] arr)
// {
// for(int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write($"{arr[i]} ");
// }
// }

// 2 метод

// int[] array = new int[] { 1, 2, 3 };
// var str = string.Join(" ", array);
// Console.WriteLine(str);


//Разделить массив

// string[] SplitNumber(string dat)
// {
// string[] splitData = dat.Split(',');
// return splitData;
// }

//найти сумму!!


// int GetSum(int arg)
// {
// if (arg == 1)
// {
//     return 1;
// }
// int sum = 0;
// for(int i = 1; i <= arg; i++)
// {
//     sum += i; 
// }
// return sum;
// }


//---------------------------------------------------------------------------------------------


// task

// System.Console.WriteLine("Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());


// List<int> FillNewArray(int num)
// {
//     List<int> list = new List<int>();
//     for (int i = 1; i <= num; i++)
//     {
//         if (i % 2 == 0)
//         {
//             list.Add(i);
//         }
//     }
//     return list;
// }

// void PrintArray(List<int> list)
// {
//     for (int i = 0; i < list.Count; i++)
//     {
//         System.Console.Write($"{list[i]} ");
//     }
// }

// List<int> list = FillNewArray(number);
// PrintArray(list);


//Task 31

// int[] array = new int [12];

// int[] FillArray(int[] arr)
// {
// Random random =  new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(-9, 10);

//     }
//     return arr;
// }


// void PrintArray(int[] arr)
// {
// for(int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write($"{arr[i]} ");
// }
// }

// int FindSumNegativeNumbers(int[] arr)
// {
// int sum = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] < 0)
//     {
//         sum += arr[i];
//     }
// }
// return sum;
// }

// int FindSumPositiveNumbers(int[] arr)
// {
// int sum = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] > 0)
//     {
//         sum += arr[i];
//     }
// }
// return sum;
// }
// int[] result = FillArray(array);
// PrintArray(result);
// System.Console.WriteLine();
// int positiveNumbers = FindSumPositiveNumbers(result);
// int negativeNumbers = FindSumNegativeNumbers(result);
// System.Console.WriteLine($"Sum of positive numbers = {positiveNumbers} and sum of negative numbers = {negativeNumbers}");





//Task 32

// int[] array = new int [12];

// int[] FillArray(int[] arr)
// {
// Random random =  new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(-9, 10);

//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
// for(int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write($"{arr[i]} ");
// }
// }

// int[] ChangeAllElements(int[] arr)
// {
//     int[] arr2 = new int [12];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr2[i] = -arr[i];
//     }
//     return arr2;
// }

// int[] result = FillArray(array);
// PrintArray(result);
// System.Console.WriteLine();
// int[] change = ChangeAllElements(result);
// PrintArray(change);


// Task 33

// int[] array = {6 , 7 , 19 , 345 , 3};
// System.Console.WriteLine("Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());



// bool FindNumberInMassive(int[] arr , int num)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] == num)
//         {
//             return true;
//         }

//     }
//     return false;
// }

// bool result = FindNumberInMassive(array , number);
// if (result == true)
// {
//     Console.WriteLine($"the number {number} has in massive!");
// }
// else
// {
//     System.Console.WriteLine($"the number {number} doesn't have in massive!");
// }


// Task 35

// int[] array = new int[123];

// int[] FillArray(int[] arr)
// {
// Random random =  new Random();
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(0, 150);

//     }
//     return arr;
// }


// void PrintArray(int[] arr)
// {
// for(int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write($"{arr[i]} ");
// }
// }


// int CheckCountOfNumbers(int[] arr)
// {
// int count = 0; 
// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] >= 10 && arr[i] <= 99)
//     {
//         count++;
//     }
// }
// return count;
// }

// int[] result = FillArray(array);
// PrintArray(result);
// int count = CheckCountOfNumbers(result);
// System.Console.WriteLine();
// System.Console.WriteLine($"the {count} numbers have in the massive!");



// Task 37.

int[] array = new int[10];

int[] FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(1, 10);

    }
    return arr;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

int[] FindMultiplyNumbers(int[] arr)
{
    if (arr.Length % 2 == 1)
    {
        int[] multiplyNumbers = new int[arr.Length / 2 + 1];
        for (int i = 0; i < arr.Length / 2 + 1; i++)
        {
            if (arr[i] == arr[arr.Length - 1 - i])
            {
                multiplyNumbers[i] = arr[i];
            }
            else
            {
                multiplyNumbers[i] = arr[i] * arr[arr.Length - 1 - i];
            }

        }
        return multiplyNumbers;
    }

    else
    {
        int[] multiplyNumbers2 = new int[arr.Length / 2];
        for (int i = 0; i < arr.Length / 2; i++)
        {
            multiplyNumbers2[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        return multiplyNumbers2;
    }

}

int[] n = FillArray(array);
PrintArray(n);
System.Console.WriteLine();
int[] result = FindMultiplyNumbers(n);
PrintArray(result);