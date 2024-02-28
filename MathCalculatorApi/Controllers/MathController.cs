using MathCalculatorApi.Extensions;
using MathCalculatorApi.Responses;
using Microsoft.AspNetCore.Mvc;

namespace MathCalculatorApi.Controllers;

[ApiController]
[Route("/[controller]")]
public class MathController : ControllerBase
{
    [HttpPost("add")]
    public ActionResult Add(ICollection<int> nums)
    {
        var s = nums.Sum();
        return new BasicArithmeticResponse(s, nums)
            .ToJsonResult();
    }

    [HttpGet("add")]
    public ActionResult Add(int x, int y)
    {
        return new BasicArithmeticResponse(x + y, x, y)
            .ToJsonResult();
    }

    [HttpGet("subtract")]
    public ActionResult Subtract(int x, int y)
    {
        return new BasicArithmeticResponse(x - y, x, y)
            .ToJsonResult();
    }

    [HttpGet("multiply")]
    public ActionResult Multiply(int x, int y)
    {
        return new BasicArithmeticResponse(x * y, x, y)
            .ToJsonResult();
    }
    
    [HttpPost("multiply")]
    public ActionResult Multiply(ICollection<int> nums)
    {
        var p = nums.Aggregate(1, (state, next) => state * next);
        return new BasicArithmeticResponse(p, nums)
            .ToJsonResult();
    }
}