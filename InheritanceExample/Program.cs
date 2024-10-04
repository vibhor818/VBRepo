



using System.Numerics;

Manager manager = new Manager();
manager.ManagerPublicMember();

AssistantManager am = new AssistantManager();
am.AManagerMember();
public class Employee
{
  
    public void EmployeePublicMember()
    {        
        Console.WriteLine("I am the public member of Employee class");
    }
    private void EmployeePrivateMember()
    {       
        Console.WriteLine("I am the private member of Employee class");
    }
    
    protected void EmployeeProtectedMember()
    {
        EmployeePrivateMember();
        Console.WriteLine("I am the protected member of Employee class");
    }
}
public class Manager:Employee
{
    public void ManagerPublicMember() 
    {
        EmployeePublicMember();
        EmployeeProtectedMember();
        
    }
    protected void ManagerProtectedMember()
    {
        Console.WriteLine("I am the protected member of Manager class");

    }
}
public class AssistantManager : Manager
{
    public void AManagerMember()
    {
        EmployeePublicMember();
        ManagerProtectedMember();
    }
}