// Выяснить является ли число чётным

string msg = "Enter the number: ";
int nmbr = GetIntNmbr(msg);

EvenOdd(nmbr);

int GetIntNmbr(string msg)
{
    int outpt = 0;
    bool smthngOrNmbr = false;
    while (smthngOrNmbr == false)
    {
        Console.Write(msg);
        smthngOrNmbr = int.TryParse(Console.ReadLine(), out outpt);
    }
    return outpt;
}

void EvenOdd(int nmbr)
{
    if (nmbr % 2 == 0)
        Console.WriteLine("\n{0} is even", nmbr);
    else
        Console.WriteLine("\n{0} is odd", nmbr);
}