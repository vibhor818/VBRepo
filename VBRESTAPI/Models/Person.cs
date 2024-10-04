namespace VBRESTAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class PersonData
    {
        List<Person> People;
        public PersonData()
        {
            People = new List<Person>();
            People.Add(new Person { Id = 1, Name = "John", Address = "USA" });
            People.Add(new Person { Id = 2, Name = "Steve", Address = "UK" });
            People.Add(new Person { Id = 3, Name = "Camilla", Address = "Italy" });
        }
        public List<Person> GetPeople()
        {
            return People;
        }
    }
}
