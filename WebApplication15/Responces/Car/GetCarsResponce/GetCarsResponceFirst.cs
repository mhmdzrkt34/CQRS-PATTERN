using shared;

namespace WebApplication15.Responces.Car.GetCarsResponce
{
    public class GetCarsResponceFirst:GetCarsResponceBase
    {

        
        public int statusCode {  get; set; }

        public List<shared.Car> message { get; set; }
    }
}
