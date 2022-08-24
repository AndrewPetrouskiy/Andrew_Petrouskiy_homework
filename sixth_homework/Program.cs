// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] FillManualArray(int number)
{
    int[] num = new int[number];
    System.Console.WriteLine($"Enter the number for manual fill the array {number} times");
    for (int i = 0; i < number; i++)
    {

        num[i] = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CheckCountOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


// Console.Write("Enter the count of numbers ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] Array = FillManualArray(number);
// int countPositiveNumbers = CheckCountOfPositiveNumbers(Array);
// System.Console.WriteLine();
// System.Console.Write($"{countPositiveNumbers} it's a count positive number in array ");
// PrintArray(Array);


//======================================================================================================

//Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.



double FindIntersectionPointCoordinateX(double b1, double k1, double b2, double k2)
{
    double X = (b2 - b1) / (k1 - k2);
    return X;
}

double FindIntersectionPointCoordinateY(double X, double b2, double k2)
{
    double Y = k2 * X + b2;
    return Y;
}

// Console.Write("Enter the b1 ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the k1 ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the b2 ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter the k2 ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2)
// {
//     System.Console.WriteLine("These lines are parallel"); ;
// }
// else
// {
//     double X = FindIntersectionPointCoordinateX(b1, k1, b2, k2);
//     double Y = FindIntersectionPointCoordinateY(X, b2, k2);
//     System.Console.WriteLine($"X = {X}, Y = {Y}");
// }


