int Sum(int M, int N)
{
    if( M == N) return M;
    else return (N + Sum(M, N - 1));
}

System.Console.WriteLine(Sum(1, 15));
