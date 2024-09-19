using Microsoft.AspNetCore.Mvc;

namespace WestCoast_Cars.Namespace
{
        [Route("vehicles")]
    public class VehiclesController : Controller
    {
        // GET: Vehicles
        public ActionResult Index()
        {
            ViewBag.Message = "Här kommer en lista på häftiga bilar";
            ViewData.Add("Test", "ViewData funkar också!");

            return View("Index");
        }

    [HttpGet("list")]
    public IActionResult List()
    {
        VehicleModel model = new VehicleModel();
        List<VehicleViewModel> vehicleList = model.Vehicles();

        ViewBag.Message = "Jag kommer ifrån List metoden";
        return View("List", vehicleList);
    }

    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
    ViewBag.Message = $"Här är detaljerna för den valda bilen med id {id}";
    return View("Details");
    }

    [HttpGet("find/{id}")]
    public IActionResult Find(int id)
    {
        return View("Details");
    }

    [HttpDelete("delete/{id}")]
    public IActionResult Delete(int id)
    {

        ViewBag.Message = "Finns inte längre";
        return View("Details");
    }


    }


}
