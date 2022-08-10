// Task 10 - Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int showsecondfigure(int arg)
{
 int figure = arg / 10;
 int figure2 = figure % 10;
 return figure2;
}

// Console.Write("Enter the number ");
// int input = Convert.ToInt32(Console.ReadLine());
// var figure2 = showsecondfigure(input);
// Console.WriteLine($"{figure2} is second figure from {input}");



// Task 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int? showthirdfigure(int arg)
{
    if(arg / 100 == 0)
    return null;

    int figure = arg / 100;

    if(figure < 10){
        return figure;
    }
    else{
        figure = figure % 10;
        return figure;
    }
}

// Console.Write("Enter the number ");
// int input = Convert.ToInt32(Console.ReadLine());
// var figure = showthirdfigure(input);
// if(figure == null)
// {
//     Console.WriteLine("Third figure doesn't exist");
// }
// else
// {
//     Console.WriteLine($"{figure} is the third figure of {input}");
// }



// Task 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool checkweekend(int arg)
{
if(arg > 5 & arg <= 7)
{
    return true;
}
else
{
    return false;
}
}


Console.Write("Enter the number of day ");
int input = Convert.ToInt32(Console.ReadLine());
bool result = checkweekend(input);
if(result == true)
{
    Console.WriteLine("It's a weekend");
}
else
{
    Console.WriteLine("It isn't a weekend");
}
