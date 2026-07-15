using Microsoft.AspNetCore.Mvc;
using Rotex.Lively.Web.Client.DummyData;

namespace Rotex.Lively.Web.Client.Areas.Creator.Controllers
{
    [Area("Creator")]
    public class GoLiveController : Controller
    {
        // GET: /Creator/GoLive
        // GET: /Creator/GoLive/Index?showId=xxx
        public IActionResult Index(string? showId = null)
        {
            var viewModel = GoLiveData.Get(showId);
            return View(viewModel);
        }
    }
}