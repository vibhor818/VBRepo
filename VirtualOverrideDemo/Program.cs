




//Person per = new Person();
//per.Name = "Vibhor" ;
//Console.WriteLine(per.ToString());
using System.Text;

People people = new VegPeople();
people.Eating();
people=new NonVegPeople();
people.Eating();


public class People
{
    public virtual void Eating()
    {
        Console.WriteLine("All People eat");
    }
}
public class VegPeople:People
{
    public override void Eating()
    {
        base.Eating();
        Console.WriteLine("In this category People eat veg");
    }
}
public class NonVegPeople : People
{
    public  override void Eating()
    {
        Console.WriteLine("In this category People eat non veg");
    }
}
public class Person
{
    public string Name { get; set; }
    public override string ToString()
    {
        return Name;
    }
}
