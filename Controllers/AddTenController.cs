using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace My_First_Project_N01512310_Emeka.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/AddTen
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/AddTen/5
        public string Get(int id)
        {
            return id + 10;
        }

        // POST api/AddTen
        public void Post([FromBody] string value)
        {
        }

        // PUT api/AddTen/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/AddTen/5
        public void Delete(int id)
        {
        }
    }
}
