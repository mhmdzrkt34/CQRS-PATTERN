using MediatR;
using System.ComponentModel.DataAnnotations;
using WebApplication15.Responces.Car.AddCar;

namespace WebApplication15.CommandsQueries.Car.commands.AddCar
{
    public class AddCarCommand:IRequest<AddCarResponceBase>
    {

        [Required]
        public string name {  get; set; }
    }
}
