
using System.Collections;
using System.Diagnostics;

//ArrayList aList=new ArrayList();
//aList.Add(112);
//aList.Add(34.56);
//aList.Add("Hello");

//foreach(var i in aList)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("====================");
//aList.Remove(34.56);
//foreach (var i in aList)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("=========================");
//Hashtable ht=new Hashtable();
//ht.Add("aa", 112);
//ht.Add(1, "My Value");
//ht.Add(2.9, "Sample Data");

//Console.WriteLine(ht[2.9]);


ArrayList data=new ArrayList();
data.Add(new Person { Age = 12, Name = "John", Address = "USA" });
data.Add(new Person { Age = 22, Name = "STeve", Address = "UK" });
data.Add(new Person { Age = 32, Name = "Fey", Address = "Italy" });

var d = from Person a in data
        //where a.Name == "Fey"
        select a;

Console.WriteLine(d.Max(a=>a.Age).ToString());


foreach (Person person in data)
{
    Console.WriteLine(person.Age+"   "+person.Name+"   "+person.Address);
}

public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}

