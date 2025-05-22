using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ErrorHandling.Web.Controllers;
public class ErrorController : Controller
{
    [HttpGet("error/exception")]
    public IActionResult ServerError()
    {
        var error = HttpContext.Features.Get<IExceptionHandlerPathFeature>()?.Error;

        if (error != null)
        {
            Debug.WriteLine(error.Message);
        }
        return View();
    }

    [HttpGet("error/http/{statusCode}")]
    public IActionResult HttpError(int statusCode)
    {

        return View(statusCode);
    }
}
