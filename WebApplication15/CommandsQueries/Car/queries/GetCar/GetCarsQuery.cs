using MediatR;
using WebApplication15.Responces.Car.GetCarsResponce;

namespace WebApplication15.CommandsQueries.Car.queries.GetCar
{
    public class GetCarQuery:IRequest<GetCarsResponceBase>
    {
    }
}
