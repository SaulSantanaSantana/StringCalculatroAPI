using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StringCalculatroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringCalculatorController : ControllerBase
    {

        // GET api/<StringCalculatorController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            StringCalculatorClass calc = new StringCalculatorClass();
            string res = calc.add(id).ToString();
            return res;
        }

    }
}
