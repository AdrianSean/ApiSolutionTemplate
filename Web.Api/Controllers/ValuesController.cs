using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Web.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Values")]
    public class ValuesController : Controller
    {
        readonly ILogger _log;

        public ValuesController(ILogger log)
        {
            _log = log;
        }


        // GET: api/Default
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _log.Information("Calling GET api/values");
            return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            _log.Information("Calling GET api/values/{id}", id);
            return "value";
        }
        
        // POST: api/Default
        [HttpPost]
        public void Post([FromBody]string value)
        {
            _log.Information("Calling POST api/values");
        }
        
        // PUT: api/Default/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            _log.Information("Calling PUT api/values");
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _log.Information("Calling DELETE api/values");
        }
    }
}
