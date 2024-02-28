using Microsoft.AspNetCore.Mvc;

namespace MathCalculatorApi.Controllers;

[ApiController]
[Route("/[controller]")]
public class MathController : ControllerBase
{
    [HttpPost("add")]
    public ActionResult Add(ICollection<int> nums)
    {
        return new JsonResult(new
        {
            nums,
            sum = nums.Sum()
        });
    }

    [HttpGet("add")]
    public ActionResult Add(int x, int y)
    {
        return new JsonResult(new
        {
            nums = new[] { x, y },
            sum = x + y
        });
    }

    [HttpGet("subtract")]
    public ActionResult Subtract(int x, int y)
    {
        return new JsonResult(new
        {
            nums = new[] { x, y },
            diff = x - y
        });
    }

    [HttpGet("multiply")]
    public ActionResult Multiply(int x, int y)
    {
        return new JsonResult(new
        {
            nums = new[] { x, y },
            prod = x * y
        });
    }
    
    [HttpPost("multiply")]
    public ActionResult Multiply(ICollection<int> nums)
    {
        return new JsonResult(new
        {
            nums,
            prod = nums.Aggregate(1, (state, next) => state * next)
        });
    }
}