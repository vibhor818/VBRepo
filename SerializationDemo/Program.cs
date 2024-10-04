
using Newtonsoft.Json;
Customer cust = new Customer();
cust.CustName = "Test";
cust.CustAddress = "USA";

string jsonData=JsonConvert.SerializeObject(cust);
Console.WriteLine(jsonData);

Customer newObj=JsonConvert.DeserializeObject<Customer>(jsonData);
Console.WriteLine(newObj.CustName+"   "+cust.CustAddress);












public class Customer
{
    public string CustName { get; set; }
    public string CustAddress { get; set; }

}
