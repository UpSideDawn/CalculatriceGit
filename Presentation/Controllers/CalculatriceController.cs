using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatriceController : ControllerBase
    {
        //private OperationServices _services;// = new OperationServices();
        private IServiceManager _servicemanager;

        public CalculatriceController(IServiceManager serviceManager)
        {

            _servicemanager = serviceManager;
        }

        [HttpGet("addition")]
      public ActionResult<double> GetResultAddition([FromQuery]List<double> doubles)
        {
            //          return Ok(_services.Addition(doubles));
            return Ok(_servicemanager.OperationService.Addition(doubles));
        }

        [HttpGet("basicAddition")]
        public ActionResult<double> GetResultAdditionBasic(double Number1, double Number2)
        {
            return Ok(_servicemanager.OperationBasiqueService.Addition(Number1, Number2));
        }
        [HttpGet("basicSoustraction")]
        public ActionResult<double> GetResultSoustractionBasic(double Number1, double Number2)
        {
            return Ok(_servicemanager.OperationBasiqueService.Soustraction(Number1, Number2));
        }
        [HttpGet("basicMultiplication")]
        public ActionResult<double> GetResultMultiplicationBasic(double Number1, double Number2)
        {
            return Ok(_servicemanager.OperationBasiqueService.Multiplication(Number1, Number2));
        }
        [HttpGet("basicDivision")]
        public ActionResult<double> GetResultDivisionBasic(double Number1, double Number2)
        {
            return Ok(_servicemanager.OperationBasiqueService.Division(Number1, Number2));
        }
    }
}
