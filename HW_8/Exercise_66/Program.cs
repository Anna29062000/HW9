int GetSum(int n, int m) //получение суммы элементов между N и M
{
    if (m == n)
    {
        return n;
    }
    else 
    {
        return m + GetSum(n, m - 1);
    }
}


Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.Write(GetSum(n + 1, m - 1));
}
else if (n > m)
{
    Console.Write(GetSum(m + 1, n - 1));
}
else if (m == n)
{
    Console.Write("Числа равны!");
}