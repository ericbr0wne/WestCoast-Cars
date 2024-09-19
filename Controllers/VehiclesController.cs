using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using WestCoast_Cars.Data;
using WestCoast_Cars.Models;

namespace WestCoast_Cars.Namespace
{
        [Route("vehicles")]
    public class VehiclesController : Controller
    {
        private readonly WestCoastCarsContext _context;

        public VehiclesController(WestCoastCarsContext context) 
        {
            _context = context;
            
        }
        // GET: Vehicles
        public ActionResult Index()
        {

        VehicleModel model = new VehicleModel();
        List<VehicleViewModel> vehicleList = model.GetVehicles();

        return View("Index", vehicleList);
        }


    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
        VehicleModel model = new();
        VehicleViewModel vehicle = model.Find(id); 
    return View("Details", vehicle);
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
