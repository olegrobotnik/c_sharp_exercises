// Показать вторую цифру трёхзначного числа

int nmbr = GetIntNmbr("Enter a three-digit number: ", (100, 999));
int dig = SlctdDig(nmbr, 2);
Console.WriteLine($"\nThe second digit is {dig}");
Console.ReadKey();

int SlctdDig(int nmbr, int pos)
{
    int tmp = nmbr / (int)Math.Pow(10, pos - 1);
    int slctdDig = tmp % 10;
    return slctdDig;
}

int GetIntNmbr(string msg, (int?, int?) rng)
{
    int outpt = 0;
    bool smthngOrNmbr = false;
    while (smthngOrNmbr == false)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out outpt))
        {
            smthngOrNmbr = outpt >= rng.Item1 && outpt <= rng.Item2;
        }
    }
    return Math.Abs(outpt);
}