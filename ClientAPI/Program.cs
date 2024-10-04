

using Newtonsoft.Json;

ConsumeService();
Console.ReadLine();

async Task ConsumeService()
{
    try
    {


        var client = new HttpClient();
        var response =await client.GetAsync("http://localhost:5131/api/Person");
        var result =await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<List<PersonJson>>(result);
        foreach (var item in data)
        {
            Console.WriteLine(item.Id + "   " + item.Name + "  " + item.Address);
        }
    }
    catch(HttpRequestException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
public class PersonJson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}