using CallACar.Logic;
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
            return new OkObjectResult("NOT IMPLEMENTED");
        }
        
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
        
        [HttpPost]
        public IActionResult Add()
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
        
        [HttpPut("{id}")]
        public IActionResult Update()
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete()
        {
            return new OkObjectResult("NOT IMPLEMENTED");
        }
    }
}