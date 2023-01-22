int ToThePower(int A, int B)
{
    int res = A;
    for (int i = 0; i < B - 1; i++) 
    {
        res *= A;
    }
    return res;
}
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ToThePower(x, y));