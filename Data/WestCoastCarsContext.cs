using Microsoft.EntityFrameworkCore;
using WestCoast_Cars.Models;

namespace WestCoast_Cars.Data;

public class WestCoastCarsContext : DbContext
{

    /* Properties */

    public DbSet<VehicleViewModel> Vehicles { get; set; }

    /* Constructors */
    public WestCoastCarsContext(DbContextOptions options) : base(options)
    {
        
    }

}
