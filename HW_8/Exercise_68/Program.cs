int FancAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return FancAckerman( m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return FancAckerman(m - 1, FancAckerman(m, n - 1));
    }
    else
    {
        return 0;
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if ((m == 0) || (m > 0))
{
    Console.WriteLine(FancAckerman(m, n));
}
else
{
    Console.WriteLine("При указанных значениях не существует функции Аккермана");
}
