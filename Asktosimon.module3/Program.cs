int PowerUp(int N, byte pow)
{
    if (pow == 1) return N;

    return N * PowerUp(N, (byte)(pow - 1));
}

Console.WriteLine(PowerUp(2, 3));