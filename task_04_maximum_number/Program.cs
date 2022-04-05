// Найти максимальное из трех чисел

Random rndm = new Random();

int[] arry = new int[3];
int i = 0;

while (i < arry.Length)
{
    arry[i] = rndm.Next(-2147483648, 2147483647);
    i++;
}

int maxNmbr = arry.Max();

for (int j = arry.GetLowerBound(0); j <= arry.GetUpperBound(0); j++)
{
    Console.WriteLine("   [{0,2}]: {1}", j, arry[j]);
}

Console.WriteLine();

Console.WriteLine("   The maximum is {0}", maxNmbr);
Console.ReadKey();