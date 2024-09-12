using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get() 
    {
        return new string[] { "value1", "value2" };        
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id) 
    {
        return "Eric Sällström";
    }
}