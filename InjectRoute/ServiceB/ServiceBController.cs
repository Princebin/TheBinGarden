using System.Collections.Generic;
using System.Web.Http;

namespace ServiceB
{
    [RoutePrefix("api/ServiceB")]
    public class ServiceBController : ApiController
    {
        [Route("Values")]
        [HttpGet]
        public List<string> Values()
        {
            return new List<string> { "value3", "value4" };
        }

        [Route("Version")]
        [HttpGet]
        public string Version()
        {
            return "Service B, version 1.0.0";
        }
    }
}