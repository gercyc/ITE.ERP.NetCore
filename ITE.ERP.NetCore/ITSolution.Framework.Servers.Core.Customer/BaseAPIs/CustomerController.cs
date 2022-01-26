using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITSolution.Framework.Core.CustomUserAPI.Data;
using ITSolution.Framework.Server.Core.BaseClasses.Repository;
using ITSolution.Framework.Servers.Core.CustomerApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace ITSolution.Framework.Servers.Core.FirstAPI.BaseAPIs
{
    /// <summary>
    /// Customize or create new APIs
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly CustomerContext _context;
        public CustomerController()
        {
            _context = new CustomerContext();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.CustomerRep.GetAll();
        }


        //TODO:
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return _context.CustomerRep.FirstOrDefault(id);
        }

        //TODO:
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //TODO:
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        //TODO:
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
