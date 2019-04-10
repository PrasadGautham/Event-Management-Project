using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectevent.Models;

namespace projectevent.Controllers
{
    public class admintoacceptvendorController : ApiController
    {
        // GET: api/Vendor
        public HttpResponseMessage Get()
        {
            var vendors = agentrepo.getvendordetails();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, vendors);
            return response;

        }
        // GET: api/Vendor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vendor
        public void Post([FromBody]string value)
        {
        }

        public void Put(int id)
        {
            agentrepo.acceptvendor(id);


        }
      

        // DELETE: api/Vendor/5
        public void Delete(int id)
        {
            agentrepo.deletevendor(id);
        }
    }
}
