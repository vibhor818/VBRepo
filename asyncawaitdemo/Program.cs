

AsyncMethod().Wait();
Console.WriteLine("I am the part of main method");
Console.ReadLine();

async Task AsyncMethod()
{
    Task t1 = new Task(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("I am the part of task.");
    });
    t1.Start();
    await t1;
    Console.WriteLine("I am the part of Async Method");
}
