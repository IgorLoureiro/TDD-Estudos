using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebTDD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {

        [HttpGet("Add({left}/{right}")]
        public int Get(int left, int right)
        {
            var calculator = new Calculator();
            return calculator.Sum(left, right);
        }
        
    }
}