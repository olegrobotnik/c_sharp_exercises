// Написать программу вычисления значения функции y = f(a)
// y = x * x - 5 

int nmbr = 0;
string msg = "Enter a number: ";

double x = GetIntNmbr(msg);
double y = FuncCalc(x);

Console.WriteLine($"\ny = x * x - 5 = { y}");
Console.ReadKey();

double FuncCalc(double x)
{
    double y = Math.Pow(x, 2) - 5;
    if (x == 0)
    {
        return y;
    }
    else if (x < 0)
    {
        x = Math.Abs(x);
        return y;
    }
    else
    {
        return y;
    }
}

int GetIntNmbr(string msg)
{
    bool smthngOrNmbr = false;
    while (smthngOrNmbr == false)
    {
        Console.Write(msg);
        smthngOrNmbr = int.TryParse(Console.ReadLine(), out nmbr);
    }
    return nmbr;
}