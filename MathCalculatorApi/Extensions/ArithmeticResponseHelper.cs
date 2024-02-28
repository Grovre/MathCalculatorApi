using MathCalculatorApi.Responses;
using Microsoft.AspNetCore.Mvc;

namespace MathCalculatorApi.Extensions;

public static class ArithmeticResponseHelper
{
    public static JsonResult ToJsonResult(this BasicArithmeticResponse bar)
    {
        return new JsonResult(bar);
    }
}