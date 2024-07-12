using MediatR;
using WebApplication15.Repositories.Car;
using WebApplication15.Responces.Car.AddCar;

namespace WebApplication15.CommandsQueries.Car.commands.AddCar
{
    public class AddCarCommandHandler : IRequestHandler<AddCarCommand, AddCarResponceBase>
    {

        private readonly ICarRepository _carRepository;

        public AddCarCommandHandler(ICarRepository carRepository)
        {


            _carRepository = carRepository;
        }
        public async Task<AddCarResponceBase> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
           try
            {
                AddCarResponceBase responce = await _carRepository.AddCar(request);

                return responce;

            }catch (Exception ex) {


                throw;
            }
        }
    }
}
