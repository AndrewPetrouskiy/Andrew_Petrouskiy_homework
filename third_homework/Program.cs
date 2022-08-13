
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int FindPalindrom(int number)
{
    int reversed_number = 0;
    int tmp_original = number;
    while(tmp_original > 0)
    {
        reversed_number = (reversed_number *10) + tmp_original % 10;
        tmp_original = tmp_original / 10;
    }
    return reversed_number;
}

// Console.Write("Enter the number ");
// int Original = Convert.ToInt32(Console.ReadLine());
// int Reverse = FindPalindrom(Original);
// if(Reverse == Original)
// {
//     Console.Write($"{Original} and {Reverse} are Palindrom");
// }
// else
// {
//     Console.Write($"{Original} and {Reverse} aren't Palindrom");
// }



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double Finddistance(int x1, int x2, int y1, int y2, int z1, int z2)

{
    double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    
    return AB;
}

// Console.WriteLine("Enter the x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the z2");
// int z2 = Convert.ToInt32(Console.ReadLine());


// double input = Finddistance(x1, x2, y1, y2, z1, z2);
// string Result = string.Format("{0:f}" , input); 
// Console.WriteLine(Result);



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



int[] CubicOfNumber(int n)
{
    int[] array = new int[n];

    for (int i = 1; i <= n; i++)
    {
        array[i - 1] = i * i * i;
    }
    return array;
}

// Console.WriteLine("Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] result = CubicOfNumber(number);

// for (int i = 0; i < result.Length; i++)
// {
//     Console.WriteLine(result[i]);
// }



