using System.Security.Cryptography.X509Certificates;
using WestCoast_Cars.Models;

namespace WestCoast_Cars;

public class VehicleModel
{
    // METHODSk
    public List<VehicleViewModel> GetVehicles()
    {
        List<VehicleViewModel> vehicleList = new List<VehicleViewModel>
        {
            new VehicleViewModel
            {
                Id = 1,
                RegNo = "ABC112",
                Make = "Volvo",
                Model = "V60",
                ModelYear = 1984
            },
            new VehicleViewModel
            {
                Id = 2,
                RegNo = "SOX232",
                Make = "Toyota",
                Model = "Avensis",
                ModelYear = 1984
            },
            new VehicleViewModel
            {
                Id = 3,
                RegNo = "KLF235",
                Make = "Ford",
                Model = "V0",
                ModelYear = 1984
            }
        };
        return vehicleList;
    }


public VehicleViewModel Find(int id)
{
      
        return List<VehicleViewModel> vehicleList = new List<VehicleViewModel>
        {
            new VehicleViewModel
            {
                Id = 1,
                RegNo = "ABC112",
                Make = "Volvo",
                Model = "V60",
                ModelYear = 1984
            },
            new VehicleViewModel
            {
                Id = 2,
                RegNo = "SOX232",
                Make = "Toyota",
                Model = "Avensis",
                ModelYear = 1984
            },
            new VehicleViewModel
            {
                Id = 3,
                RegNo = "KLF235",
                Make = "Ford",
                Model = "V0",
                ModelYear = 1984
            }
        }
    }
}
