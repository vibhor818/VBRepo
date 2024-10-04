


AbstractClass ac = new SampleClass();
ac.SimpleMethod();
ac.AbstractMethod();

public abstract class AbstractClass
{
    public void SimpleMethod()
    {
        Console.WriteLine("I am simple method");
    }
    public abstract void AbstractMethod();
}
public  class SampleClass:AbstractClass
{
    public sealed override void AbstractMethod()
    {
        Console.WriteLine("I am abstarct method");
    }
}
public class NewClass: SampleClass
{
    //public override void AbstractMethod()
    //{
       
    //}

}