using System.Collections.Generic;
using System.Web.Http;

namespace ServiceA
{
    [RoutePrefix("api/ServiceA")]
    public class ServiceAController : ApiController
    {
        [Route("Values")]
        [HttpGet]
        public List<string> Values()
        {
            return new List<string> { "value1", "value2" };
        }

        [Route("Version")]
        [HttpGet]
        public string Version()
        {
            return "Service A, version 1.0.0";
        }
    }
}