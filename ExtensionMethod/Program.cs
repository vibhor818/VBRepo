


class Program
{
    public static void Main(string[] args)
    {
        int num = 100;
        num.Arjun();
    }
}


public static class VBClass
{
    public static void Arjun(this int n)
    {
        n = n + 1000;
        Console.WriteLine(n);
    }
}