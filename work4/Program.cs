// Console.WriteLine("enter a");
// double a = double.Parse(Console.ReadLine());
// Console.WriteLine("enter b");
// double b = double.Parse(Console.ReadLine());
// Console.WriteLine("enter c");
// double c = double.Parse(Console.ReadLine());

// double p = (a + b + c) / 2;

// double area = Math.Sqrt(p * (p - b) * (p - c) * (p - c));
// string area2 = string.Format("{0:f}" , area); ;
// Console.WriteLine($"area of triangle are equal {area2}");



// Control task

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
// System.Console.WriteLine("Введите число!");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = GetSum(number);
// Console.WriteLine($"Sum of all the values equals {result}");









//Task 28 solution 1


// int GetFactorial(int n)
// {
//     if (n == 1) return 1;
    
//     return n * Factorial(n - 1);
// }

//  Console.WriteLine("enter the number");
//  int number = int.Parse(Console.ReadLine());

//  int result = GetFactorial(number);
//  System.Console.WriteLine(result);

//Task 28 solution 2

// int GetFactorial(int arg)
// {
// if (arg == 1)
// {
//     return 1;
// }
// int factorial = 1;
// for(int i = 1; i <= arg; i++)
// {
//     factorial *= i; 
// }
// return factorial;
// }
// System.Console.WriteLine("Введите число!");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = GetFactorial(number);
// System.Console.WriteLine(result);
 









 // Task 26
// Console.WriteLine("enter the number");
// string number = Console.ReadLine();

// bool isNum = int.TryParse(number, out int result);
// if (isNum == false)
// {
// System.Console.WriteLine("You don't enter the number!! Please enter the number");
// return;
// }


// int LenghtOfNumber(int arg)
// {

// string number = arg.ToString();
// return number.Length;
// }

// int res = LenghtOfNumber(result);
// System.Console.WriteLine($"The lenght of number equals {res}");














//Task 30

// int[] array = new int[8];

// int[] FillArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
        
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

// int[] newList = FillArray(array);
// PrintArray(newList);



