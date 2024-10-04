
ITestInterface test = new TestClass();
test.Call();
ITest2Interface test2=new TestClass();
Console.WriteLine(test2.Add(10,20));
Console.WriteLine(  "===============================");
test =new Test2Class();
test.Call();
public interface ITestInterface
{
  
    //decalre member
    void Call();
}
public interface ITest2Interface
{
    //decalre member
    int Add(int a,int b);
}
public class TestClass : ITestInterface,ITest2Interface
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public void Call()
    {
        Console.WriteLine("I am the memebr of interface but def. given by class");
    }
}
public class Test2Class : ITestInterface,IComparable
{
    public void Call()
    {
        Console.WriteLine("Haha ha ha");
        Console.WriteLine("I am the memebr of interface but def. given by test 2 class");
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}
 public class Sample//default access modifier is internal
{
    string test;//default access modifier is private
}
