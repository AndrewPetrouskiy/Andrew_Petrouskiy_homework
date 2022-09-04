// Это решение 63 и 65 задачи!!!

// System.Console.WriteLine("Введие число");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введие второе число");
// int index = Convert.ToInt32(Console.ReadLine());
// Console.Clear();

// void PrintNumbers(int num, int index = 1)
// {
//     System.Console.Write($" {index}");
//     if (index < num)
//     {
//         PrintNumbers(num, index + 1);
//     }
// }
// PrintNumbers(number, index);

//===================================================================================================

//Задача 67. Найти сумму цифр в числе с помощью рекурсии!

// System.Console.WriteLine("Введие число");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumFiguresInNumber(int num)
// {
//     int sum = 0;
//     if (num < 10)
//     {
//         return sum + num % 10;
//     }
//     else
//     {
//         return sum = num % 10 + SumFiguresInNumber(num / 10);
//     }
// }

// int sum = SumFiguresInNumber(number);
// System.Console.WriteLine($"The sum of figures from a {number} equals {sum}");

// Задача 69. возвести число А в степень числа В.

Console.Clear();
System.Console.WriteLine("Введие число.");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие степень в которую мы возведем число.");
int pow = Convert.ToInt32(Console.ReadLine());

int MathPow(int num, int pow)
{
    int result = num;
    if(pow > 0)
    {
        result = result * MathPow(num, pow -1);
    }
    else
    {
        return 1;
    }
    return result;
}
System.Console.WriteLine(MathPow(number, pow));








