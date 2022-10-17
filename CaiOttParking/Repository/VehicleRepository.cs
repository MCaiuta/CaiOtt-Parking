using CaiOttParking.Models;

namespace CaiOttParking.Repository
{
    public interface IVehicleRepository
    {
        public void CreateVehicle();
    }
    public class VehicleRepository: IVehicleRepository
    {
        private readonly _DbContext _dbContext;
        public VehicleRepository(_DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateVehicle()
        {
                        
        }
    }
}
