int GetNum(int n) //получение натуральных чисел от N до 1
{
    Console.Write(n + " ");

    if (n == 1)
    {
        return 1;
    }
    else 
    {
        return GetNum(n - 1);
    }
}

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

GetNum(n);
