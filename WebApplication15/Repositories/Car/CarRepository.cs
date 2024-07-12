using WebApplication15.CommandsQueries.Car.commands.AddCar;
using WebApplication15.Responces.Car.AddCar;
using WebApplication15.Responces.Car.GetCarsResponce;

namespace WebApplication15.Repositories.Car
{
    public class CarRepository : ICarRepository
    {
        public async Task<AddCarResponceBase> AddCar(AddCarCommand request)
        {
            try
            {
                await Task.Delay(1000);

                shared.seeded.cars.Add(new shared.Car()
                {

                    name = request.name
                });

                return new AddCarResponceFirst()
                {

                    statusCode = 201,
                    message = "car added successfully"
                };



            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<GetCarsResponceBase> GetCars()
        {
            try
            {

                await Task.Delay(2000);
                List<shared.Car> cars = shared.seeded.cars;
                Console.WriteLine(cars.Count);

                return new GetCarsResponceFirst()
                {

                    statusCode = 200,
                    message = cars
                };



            }catch (Exception ex)
            {


                throw;
            }
        }
    }
}
