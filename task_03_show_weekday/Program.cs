// По заданному номеру дня недели вывести его название

string[] weekdays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
int nmbr = GetIntNmbr("Enter a weekday number: ", (1, 7));

Console.WriteLine(weekdays[nmbr - 1]);
Console.ReadKey();

int GetIntNmbr(string msg, (int, int) range)
{
    int outpt = 0;
    bool rslt = false;

    while (rslt == false)
    {
        Console.Write(msg);
        string? inpt = Console.ReadLine();
        if (int.TryParse(inpt, out outpt))
        {
            rslt = outpt >= range.Item1 && outpt <= range.Item2;
        }
    }
    return outpt;
}