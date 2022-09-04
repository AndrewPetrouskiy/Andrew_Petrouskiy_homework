// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// System.Console.WriteLine("Enter the number M");
// int numberM = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter the number N");
// int numberN = Convert.ToInt32(Console.ReadLine());
// Console.Clear();

// void PrintNumbers(int numM, int numN )
// {
//     System.Console.Write($" {numM}");
//     if (numM < numN)
//     {
//         PrintNumbers(numM + 1, numN);
//     }
// }
// PrintNumbers(numberM, numberN);


//=================================================================================================
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// System.Console.WriteLine("Enter the first number");
// int numberM = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter the second number");
// int numberN = Convert.ToInt32(Console.ReadLine());


// int FindSumBetweenMAndN(int m, int n)
// {
//     int sum = m;
//     if(m < n)
//     {
//         sum = sum + FindSumBetweenMAndN(m +1, n);
//     }
//     return sum;
// }

// if(numberM == numberN)
// {

//     System.Console.WriteLine($"{numberM} equals {numberM} and their sum equals 0");
// }
// else
// {
// int sumMandN = FindSumBetweenMAndN(numberM, numberN);
// System.Console.WriteLine($"The sum between {numberM} and {numberN} equals {sumMandN}");
// }


//=========================================================================================
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

System.Console.WriteLine("Enter the first number");
uint numberM = Convert.ToUInt32(Console.ReadLine());
System.Console.WriteLine("Enter the second number");
uint numberN = Convert.ToUInt32(Console.ReadLine());


uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

if(numberM < 0 || numberN < 0)
{
    System.Console.WriteLine("You need to enter only positive numbers");
}
else
{
    uint ackermannFunction = A(numberN , numberM);
    System.Console.WriteLine($"The result Ackerman function numbers {numberM} and {numberN} equals {ackermannFunction}");
}