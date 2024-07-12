using MediatR;
using WebApplication15.Repositories.Car;
using WebApplication15.Responces.Car.GetCarsResponce;

namespace WebApplication15.CommandsQueries.Car.queries.GetCar
{
    public class GetCarsQueryHandler : IRequestHandler<GetCarQuery, GetCarsResponceBase>
    {

        private readonly ICarRepository _carRepository;

        public GetCarsQueryHandler(ICarRepository carRepository)
        {


            _carRepository = carRepository; 
        }
        public async Task<GetCarsResponceBase> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
           try
            {


                GetCarsResponceBase responce = await _carRepository.GetCars();

                return responce;

            }catch (Exception ex)
            {

                throw;
            }
        }
    }
}
