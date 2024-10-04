


DrivedClass dc = new DrivedClass("Test");

public class BaseClass
{
    public BaseClass(string s)
    {
        Console.WriteLine("I am the part of base class and I will execute first "+s);
    }
}
public class DrivedClass:BaseClass
{
    public DrivedClass(string a):base(a)
    {
        Console.WriteLine("This is child class area.");
        Console.WriteLine("I am the part of drived class and will execute after base constructor" + a);
    }
}
