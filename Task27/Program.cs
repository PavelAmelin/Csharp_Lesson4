int SumOfDig(int N)
{
    int res = 0;
    while (N != 0)
    {
        res += N % 10;
        N /= 10;
    }
    return res;
}
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDig(N));
