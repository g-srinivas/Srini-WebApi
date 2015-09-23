using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public Emp Post(Emp value)
        {
            return value;
        }

        // PUT api/values/5
        public Emp Put(Emp value)
        {
            value.Name = "Krishna";
            return value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
    public class Emp
    {
        public String Name { get; set; }
    }
}
