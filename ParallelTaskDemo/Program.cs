
Parallel.Invoke(() => MethodForFirstTask(),
                        () => MethodForSecondTask(),
                        () => MethodForThirdTask());

void MethodForThirdTask()
{
    Console.WriteLine("I will execute first");
}

void MethodForSecondTask()
{
    Thread.Sleep(5000);
    Console.WriteLine("I will execute third");
}

void MethodForFirstTask()
{
    Thread.Sleep(3000);
    Console.WriteLine("I will execute second");
}