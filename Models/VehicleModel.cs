namespace WestCoast_Cars;

public class VehicleModel
{

    //METHODS
public List<VehicleViewModel>Vehicles(){
    //HÄMTA DATA NÅGONSTANS
    List<VehicleViewModel> list = [];
    for(int i=0; i < 10; i++)
    {
        VehicleModel vehicle = new VehicleViewModel
        {
            RegNo = "1222112",
            Make = "Volvo",
            Model = "V60",
            ModelYear = 1984
        }
    }
    return [];   
}
}
