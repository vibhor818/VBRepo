



Task t1=new Task(()=>
{
    Thread.Sleep(1000);
    Console.WriteLine("this is t1 task");
});
Task t2 = t1.ContinueWith((followedUp) =>
{
    if (followedUp.Exception!=null)
    {
        Console.WriteLine("Exception");
    }
    Thread.Sleep(500);
    Console.WriteLine("this is continuation");
},TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.OnlyOnRanToCompletion);
t1.Start();
try
{
    t1.Wait();
    t2.Wait();
}
catch (AggregateException ex)
{

    Console.WriteLine(ex.InnerException.Message);
}
