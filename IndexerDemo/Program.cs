

Employee emp = new Employee();
emp[0] = "First";
emp[1] = "Second";
emp[2] = "Third";
emp["haha"] = "My Value";
Console.WriteLine(emp[1]);
Console.WriteLine(emp["haha"]);

public class Employee
{
    private string[] _name=new string[3];
    public string this[int pos]
    {
        get
        {
            return _name[pos];  
        }
        set
        {
            _name[pos] = value;
        }
    }
    private string Name;
    public string this[string s]
    {
        get
        {
            return Name;
        }
        set
        {
            Name= value;
        }
    }
}