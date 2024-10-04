

class Program
{
    public static void Main(string[] args)
    {
        Call();
        Console.WriteLine("I am the part of main method");
        Console.ReadLine();
    }
    static void Call()
    {
        Task t1 = new Task(MyMethod);
        t1.Start();

        Task t2 = new Task(()=>
        {
           // Thread.Sleep(5000);
            Console.WriteLine("I am the part of task 2");
        });
        t2.Start();

        Task<string> task1 = Task.Run<string>(() => 
   DateTime.Now.DayOfWeek.ToString());
        Console.WriteLine(task1.Result);


        Thread.Sleep(2000);
        Console.WriteLine("I am the part of call method");
    }

    private static void MyMethod()
    {
        Thread.Sleep(3000);
        Console.WriteLine("I am the task's part");
    }
}
