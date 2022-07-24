int Akerman(int m, int n)
{
    if(m == 0) return (n + 1);
    else if(m > 0 && n == 0) return Akerman(m - 1, 1);
    else return Akerman(m - 1, Akerman(m, n - 1));
}

System.Console.WriteLine(Akerman(2, 3));