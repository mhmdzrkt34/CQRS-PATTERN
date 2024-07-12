using WebApplication15.CommandsQueries.Car.commands.AddCar;
using WebApplication15.Responces.Car.AddCar;
using WebApplication15.Responces.Car.GetCarsResponce;

namespace WebApplication15.Repositories.Car
{
    public interface ICarRepository
    {

        public Task<GetCarsResponceBase> GetCars();

        public Task<AddCarResponceBase> AddCar(AddCarCommand request);
    }
}
