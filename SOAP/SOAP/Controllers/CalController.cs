using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using SOAP.Service;

namespace SOAP.Controllers
{
    [ApiController]
    [Route("CalController")]
    public class CalController : Controller
    {
        [HttpGet("Add")]
        public async Task<double> SUMAsync(double a, double b)
        {
            IOperations calService = new OperationsClient(OperationsClient.EndpointConfiguration.BasicHttpBinding_IOperations);
            return await calService.SUMAsync(a, b);
        }
        [HttpGet("Sub")]
        public async Task<double> SUBAsync(double a, double b)
        {
            IOperations calService = new OperationsClient(OperationsClient.EndpointConfiguration.BasicHttpBinding_IOperations);
            return await calService.SUBAsync(a, b);
        }
        [HttpGet("Div")]
        public async Task<double> DIVAsync(double a, double b)
        {
            IOperations calService = new OperationsClient(OperationsClient.EndpointConfiguration.BasicHttpBinding_IOperations);
            return await calService.DIVAsync(a, b);
        }
        [HttpGet("Mul")]
        public async Task<double> MULAsync(double a, double b)
        {
            IOperations calService = new OperationsClient(OperationsClient.EndpointConfiguration.BasicHttpBinding_IOperations);
            return await calService.MULAsync(a, b);
        }
    }
}

