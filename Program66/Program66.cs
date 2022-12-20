Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N (должно быть больше M)");
int n = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int m, int n)
{
    int sum = 0;
    while(m <= n)
    {
        sum += m;
        m++;
    }
    return sum;
}
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SumNumbers(m, n)}");