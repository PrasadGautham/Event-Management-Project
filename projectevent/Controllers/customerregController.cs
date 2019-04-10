using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectevent.Models;
namespace projectevent.Controllers
{
    public class customerregController : ApiController
    {
        // GET: api/customerreg
       
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/customerreg/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/customerreg/
        public HttpResponseMessage Post(customer customer)
        {
            var status = customerregrepo.Insertcustomer(customer);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, status);

            return response;
        }

        // PUT: api/customerreg/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/customerreg/5
        public void Delete(int id)
        {
        }
    }
}
