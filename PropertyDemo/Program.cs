
Employee emp = new Employee();
emp.FirstName = "John";
Console.WriteLine(emp.FirstName);

class Employee
{
   private string _firstName;
    public string FirstName
    {
        get//read only
        {
            return _firstName;
        }
        set//write only
        {
            if (value == "Vibhor")
            {
                _firstName = value;
            }
        }
    }
   private string _lastName;
}
