




using System.Collections.Generic;

List<Person> li= new List<Person>();

li.Add(new Person() { Age=12,Name="VB"});

Person p1 = new Person() { Age = 32, Name = "Raj" };
li.Add(p1);



foreach(Person p in li)
{
    Console.WriteLine(p.Age+"  "+p.Name);
}

IEnumerator<Person> myData=li.GetEnumerator();
while(myData.MoveNext())
{
    Console.WriteLine(myData.Current.Age+"   "+myData.Current.Name);
}


public class Person
{
    public int Age { get; set; }
    public string    Name { get; set; }
}
