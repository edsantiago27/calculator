using calculator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace calculator.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CalcsController : ControllerBase
{
    [HttpPost]
    public ActionResult<Output> Post([FromBody] Input input)
    {
        var calculator = new Calculator();
        var output = new Output
        {
            Expression = calculator.GenerateExpression(input.Num)
        };
        return output;
    }
}
