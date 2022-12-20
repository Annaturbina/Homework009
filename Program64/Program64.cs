Console.WriteLine("Введите целое число N:");
int N = Convert.ToInt32(Console.ReadLine());
int NumbersSequence(int N)
{
    while (N > 1)
    {
        Console.Write($"{N} ");
        N--;
    }
    return N;
}
Console.WriteLine(NumbersSequence(N));