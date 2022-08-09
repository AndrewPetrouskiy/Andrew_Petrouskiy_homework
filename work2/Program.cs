// Task1

void multiply()
{
Console.Write("Enter the first number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number % number2 == 0)
{
    Console.Write($"{number} is multply of {number2}");
}
else
{
    int remainder = number % number2;
    Console.WriteLine($"{number} isn't multply of {number2}");
    Console.WriteLine();
    Console.WriteLine($"{remainder} is remainder of the number {number} devides  into number {number2}");
}
}
// multiply();

// Task2

void devide()
{
Console.Write("Enter the number ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 & number % 23 == 0)
{
     Console.Write($"{number} is remainder 7 & 23");
}
else
{
     Console.Write($"{number} isn't remainder 7 & 23");
}
}
//devide();



// Task 3

void square()
{
Console.Write("Enter the first number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number * number ==  number2 ^ number2 * number2 ==  number)
{
    Console.Write($"{number} is square {number2}");
}

else
{
    Console.Write($"{number} isn't square {number2}");
}
}
// square();




// Task 4

void deletenumber()

{
Random random = new Random();
int number = random.Next(100, 1000);
Console.Write(number);
int number2 = number % 10;
int number3 = number / 100;
Console.Write($" {number3}{number2} ");

// int number2 = number % 10;
// int number3 = number / 100 *10;
// int number4 = number2 + number3;
// Console.Write(number4);
}

// deletenumber();