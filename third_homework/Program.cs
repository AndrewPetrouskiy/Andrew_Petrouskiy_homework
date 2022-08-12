// Task 22

// int Squreofnumber();

// Console.Write("Enter the number ");
// int N = Convert.ToInt32(Console.ReadLine());


// Console.Write("Enter the number ");
// var figure_two = Squreofnumber(input);
//  Console.WriteLine($"{figure_two} is second figure from {input}");



// Task 18



string Showrange(int number)
{

    if(number == 1)
    {
        return "x > 0 & y > 0";
    }

    if(number == 2)
    {
        return "x < 0 & y > 0";
    }

    if(number == 3)
    {
        return "x < 0 & y < 0";
    }

    if(number == 4)
    {
        return "x > 0 & y < 0";
    }

    return "-1";
    
}


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






double Finddistance(int x1, int y1, int x2, int y2)
{
    double AB = ((x2 - x1)^2 + (y2 - y1)^2)*0,5 ;
    return AB;
}


Console.Write("Enter the x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

double input = Finddistance(3 , 6 , 2 , 1);
Console.WriteLine(input);



