using ErrorHandling.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Web.Controllers;
public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet("throw")]
    public IActionResult Throw()
    {
        throw new Exception("error");
    }

    [HttpGet("slow")]
    public async Task<IActionResult> Slow()
    {
        await SlowService.DoSlowWork();
        return RedirectToAction(nameof(Index));
    }
}
