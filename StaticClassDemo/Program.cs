
class Program
{
    public static void Main(string[] args)
    {
        //NormalClass nc=new NormalClass();
        //nc.NormalMethod();
        //NormalClass.StaticMethod();
        NormalClass.num = 100;//autmatically executes the constructor
        
    }
}
static class NormalClass
{
    public static int num;
    static NormalClass()
    {
        Console.WriteLine("I am static constructor");
    }
    //public void NormalMethod()
    //{
    //    Console.WriteLine("This is normal member");
    //}
    public static void StaticMethod()
    {
        Console.WriteLine("This is static member");
    }
}


