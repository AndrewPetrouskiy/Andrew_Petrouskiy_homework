



// // Task 18



// string Showrange(int number)
// {

//     if(number == 1)
//     {
//         return "x > 0 & y > 0";
//     }

//     if(number == 2)
//     {
//         return "x < 0 & y > 0";
//     }

//     if(number == 3)
//     {
//         return "x < 0 & y < 0";
//     }

//     if(number == 4)
//     {
//         return "x > 0 & y < 0";
//     }

//     return "-1";
    
// }


// Console.Write("Enter the number ");
// int N = Convert.ToInt32(Console.ReadLine());
// string input = Showrange(N);

// if(input == "-1")
// {
//     Console.WriteLine($"{N} не уовлетворяет условию задачи" );
// }
// else
// {
// Console.Write($"{N} находится в координатах {input}");
// }



// double Finddistance(int x1, int y1, int x2, int y2)

// {
//     double AB = (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//     double AB2 = Math.Sqrt(AB);
//     return AB2;
// }

// Console.WriteLine("Enter the x1 , y1 , x2 , y2");

// double input = Finddistance(3 , 6 , 2 , 1);
// Console.WriteLine(input);



// Task 22

// int CubicOfNumber(int n)
// {
// string Result = "";
// for(int i= 1; i <= n; i++)
// {
//     Result += $" {Math.Pow(i , 3)} ";
// }
// return Result;
// }

// Console.Write("Enter the num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CubicOfNumber(num));



// Task 22 solution two

// int n = Convert.ToInt32(Console.ReadLine());

// int[] TableSquares(int s)
// {
//     int[] array = new int[s];

//     for (int i = 1; i <= n; i++)
//     {
//         array[i - 1] = i * i;
//     }
//     return array;
// }
// int[] result = TableSquares(n);
// for (int i = 0; i < result.Length; i++)
// {
//     Console.WriteLine(result[i]);
// }

