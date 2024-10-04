

class Program
{
    public static void Main(string[] args)
    {
        //executes the constructor
        Employee emp1 = new Employee("Test");//creates instance, creates memory on heap

        object obj = emp1;
        //emp1.GetObject();

        Employee emp2 = (Employee)obj;//Explict Cast

        emp2.GetInfo("John", "Rembo", 58);
        emp2.DisplayInfo();


        int num = 100;
        object myobj = num;
        int num1 =(int) myobj;
    }
}

public class Employee
{
    // private fields
    string fName;
    string lName;   
    int age;
    public Employee()//Constructor
    {
        Console.WriteLine("I will execute automatically.");
    }
    public Employee(string s)//Constructor
    {
        Console.WriteLine("I will execute automatically. "+s);
    }
    //public Employee(object o)//Constructor
    //{
    //   // Console.WriteLine("I will execute automatically. " + s);
    //}
    public void GetInfo(string fn,string ln,int a)
    {
        fName = fn;
        lName = ln;
        age = a;
    }
    public void DisplayInfo()
    {
        Console.WriteLine("First Nameis==>  "+fName+"  Last Name is==>  "+lName+"  age is==>"+age);
    }
    public object GetObject()
    {
        return new Employee();
    }
}
