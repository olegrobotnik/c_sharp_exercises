// Показать числа от -N до N

int N = GetIntNmbr("Enter a number: ");
int count = 0;

while (count <= 2 * N)
{
    Console.WriteLine("{0, 3}   | {1, 5}", count - N, N - count);
    count++;
}

int GetIntNmbr(string msg)
{
    int outpt = 0;
    bool smthngOrNmbr = false;
    while (smthngOrNmbr == false)
    {
        Console.Write(msg);
        smthngOrNmbr = int.TryParse(Console.ReadLine(), out outpt);
    }
    return Math.Abs(outpt);
}

Console.ReadKey();