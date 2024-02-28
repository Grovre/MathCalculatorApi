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
}