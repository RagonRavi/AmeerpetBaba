using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ameerpetBaba.API.DataAccessLayer;
using ameerpetBaba.API.DataEntities; 
using MongoDB.Driver; 

namespace ameerpetBaba.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

         DataAccess _db;
        public ValuesController()
        {
            _db = new DataAccess(); 
        }
        // GET api/values
        // [HttpGet]
        // public IEnumerable<userRoles> Get()
        // {
        //     DataAccess objDataAccess=new DataAccess();
        //     return new string[] { "value1", "value2" };
        // }

         [HttpGet]
        [Produces(typeof(IMongoCollection<userRoles>))]
        public IActionResult Get()
        {
            return Ok( _db.GetUserRoles());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
