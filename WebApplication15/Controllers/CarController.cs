using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication15.CommandsQueries.Car.commands.AddCar;
using WebApplication15.CommandsQueries.Car.queries.GetCar;
using WebApplication15.Responces.Car.AddCar;
using WebApplication15.Responces.Car.GetCarsResponce;

namespace WebApplication15.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private readonly IMediator _mediator;


        public CarController(IMediator mediator)
        {

            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> getCars()
        {

            try
            {

                GetCarsResponceBase responce = await _mediator.Send(new GetCarQuery());

                return StatusCode(responce.statusCode,responce);

            }
            catch(Exception ex)
            {


                return StatusCode(500, new
                {


                    message = "internal server error"
                });
            }



        }

        [HttpPost]
        public async Task<IActionResult> AddCar(AddCarCommand request)
        {

     

            try
            {


                if (!ModelState.IsValid)
                {

                    return BadRequest(ModelState);
                }

                AddCarResponceBase responce = await _mediator.Send(request);

                return StatusCode(responce.statusCode, responce);

            }
            catch (Exception ex)
            {


                return StatusCode(500, new
                {


                    message = "internal server error"
                });
            }



        }
    }
}
