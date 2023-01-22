void Array()
{
    int N = Convert.ToInt32(Console.ReadLine());
    int count = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int[count];
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, N);
        if (i < arr.Length - 1)
        Console.Write($"{arr[i]}, ");
        else
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

Array();