// Показать четные числа от 1 до N

int N = GetIntNmbr("Enter a number: ");
int count = 1;

while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
        count++;
    }
    else
    {
        count++;
    }
}
count++;

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
