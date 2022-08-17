// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double GetExponentiation(double arg1 , double arg2)
{
double arg = Math.Pow(arg1 , arg2);
return arg;
}

// Console.WriteLine("enter the number 1");
// double numberOne = double.Parse(Console.ReadLine());
// Console.WriteLine("enter the number 2");
// double numberTwo = double.Parse(Console.ReadLine());

// double result = GetExponentiation(numberOne, numberTwo);
// System.Console.WriteLine($"{numberOne} exponentiation {numberTwo} equals {result}");









// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumOfFigures(int num)
{
    int summ = 0;
    while(num > 0)
    {
        summ = summ + num % 10;
        num /= 10;
    }
    return summ;
}
// Console.WriteLine("enter the number ");
// int number = int.Parse(Console.ReadLine());
// int result = GetSumOfFigures(number);
// System.Console.WriteLine($" The sum of all figures of number {number} equals {result}");













//Задача 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



Console.WriteLine("enter the number 1");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the number 2");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the number 3");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the number 4");
int n4 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the number 5");
int n5 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the number 6");
int n6 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the number 7");
int n7 = int.Parse(Console.ReadLine());

Console.WriteLine("enter the number 8");
int n8 = int.Parse(Console.ReadLine());


int[] array = { n1, n2, n3, n4, n5, n6, n7, n8 };


void PrintArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    
}

PrintArray(array);
