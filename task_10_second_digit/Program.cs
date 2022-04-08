// Показать вторую цифру трёхзначного числа

Random rndm = new Random();
int nmbr = rndm.Next(100, 1000);
string strNmbr = nmbr.ToString("G");
Console.WriteLine(strNmbr);
int pos = int.Parse(Console.ReadLine());

char dig = strNmbr[pos - 1];
//Console.WriteLine(dig);
string txt = string.Empty;

if (pos == 1)
    txt = "The first digit is ";
else if (pos == 2)
    txt = "The second digit is ";
else if (pos == 3)
    txt = "The third digit is ";

ColoredOutpt(txt, dig);

void ColoredOutpt(string txt, char dig)
{
    Console.Write(txt);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(dig);
    Console.ResetColor();
}



//int nmbr = GetIntNmbr("Enter a three-digit number: ", (100, 999));
//int dig = SlctdDig(nmbr, 2);
//Console.WriteLine($"\nThe second digit is {dig}");
//Console.ReadKey();

//int SlctdDig(int nmbr, int pos)
//{
//    int tmp = nmbr / (int)Math.Pow(10, pos - 1);
//    int slctdDig = tmp % 10;
//    return slctdDig;
//}

//int GetIntNmbr(string msg, (int?, int?) rng)
//{
//    int outpt = 0;
//    bool smthngOrNmbr = false;
//    while (smthngOrNmbr == false)
//    {
//        Console.Write(msg);
//        if (int.TryParse(Console.ReadLine(), out outpt))
//        {
//            smthngOrNmbr = outpt >= rng.Item1 && outpt <= rng.Item2;
//        }
//    }
//    return Math.Abs(outpt);
//}