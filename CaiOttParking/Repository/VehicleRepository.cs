using CaiOttParking.Enum;
using CaiOttParking.Models;

namespace CaiOttParking.Repository
{
    public interface IVehicleRepository
    {
        public bool CreateVehicle(Vehicle vehicle);
        public List<Vehicle> GetAllVehicles(int customerId);
    }

    public class VehicleRepository: IVehicleRepository
    {
        private readonly _DbContext _db;
        public VehicleRepository(_DbContext db)
        {
            _db = db;
        }

        public List<Vehicle> GetAllVehicles(int customerId)
        {
            return _db.vehicle.Where(x => x.customerId.Equals(customerId)).ToList();
        }
        public bool CreateVehicle(Vehicle vehicle)
        {
            var vehicle_db = new Vehicle();
            try
            {
                vehicle_db.vehicleId = vehicle.vehicleId;
                vehicle_db.customerId = vehicle.customerId;
                vehicle_db.brand = vehicle.brand;
                vehicle_db.color = vehicle.color;
                vehicle_db.model = vehicle.model;
                vehicle_db.VehicleType = vehicle.VehicleType;
                _db.vehicle.Add(vehicle_db);
                _db.SaveChanges();

                if (vehicle.VehicleType == VehicleType.Car)
                {
                    var car_db = new Car();
                    car_db.vehicleId = vehicle.vehicleId;
                    car_db.doorQuantity = vehicle.doorQuantity;
                    _db.car.Add(car_db);
                    _db.SaveChanges();
                    return true;
                }
                else if (vehicle.VehicleType == VehicleType.Motorcycle)
                {
                    var motorcycle_db = new Motorcycle();
                    motorcycle_db.vehicleId = vehicle.vehicleId;
                    motorcycle_db.engineCylinder = vehicle.engineCylinder;
                    _db.motorcycle.Add(motorcycle_db);
                    _db.SaveChanges();
                    return true;
                }
                else { return false; }
            }
            catch
            {
                return false;
            }
        }
    }
}
