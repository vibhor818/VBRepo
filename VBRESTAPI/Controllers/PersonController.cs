using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VBRESTAPI.Models;

namespace VBRESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        PersonData _data;
        public PersonController()
        {
            _data = new PersonData();
        }
        public List<Person> Get()
        {
            return _data.GetPeople();
        }
    }
}
