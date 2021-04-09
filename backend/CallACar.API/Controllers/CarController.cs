using CallACar.Logic;
using CallACarr.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CallACar.API.Controllers
{
    [Route("/car")]
    public class CarController: Controller
    {
        private CarLogic _carLogic = new CarLogic();

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_carLogic.GetCars());
        }
        
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return new OkObjectResult(_carLogic.GetCarById(id));
        }
        
        [HttpPost]
        public IActionResult Add([FromBody] Car car)
        {
            this._carLogic.AddCar(car);
            return new OkResult();
        }
        
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Car car)
        {
            this._carLogic.Update(id, car);
            return new OkResult();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            this._carLogic.Remove(id);
            return new OkResult();
        }
    }
}