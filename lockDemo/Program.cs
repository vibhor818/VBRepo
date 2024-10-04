class Program
{
    static readonly Object _obj = new Object();
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++) 
        {
            ThreadStart start = new ThreadStart(LockMethod);
            new Thread(start).Start();
        }
        Console.ReadLine();
    }
    static void LockMethod()
    {
        lock (_obj)
        {
            Thread.Sleep(100);
            Console.WriteLine(Environment.CurrentManagedThreadId);
        }
    }
}
