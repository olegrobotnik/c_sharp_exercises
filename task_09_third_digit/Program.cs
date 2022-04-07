// Показать последнюю цифру трёхзначного числа

int nmbr = GetIntNmbr("Enter a three-digit number: ", (100, 999));

int thrdDig = nmbr % 10;

Console.WriteLine($"\nThird digit is {thrdDig}");
Console.ReadKey();

int GetIntNmbr(string msg, (int?, int?) rng)
{
    int outpt = 0;
    bool smthngOrNmbr = false;
    while (smthngOrNmbr == false)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out outpt))
        {
            smthngOrNmbr = rng.Item1 != null && outpt >= rng.Item1 && rng.Item1 != null && outpt <= rng.Item2;
        }
    }
    return Math.Abs(outpt);
}