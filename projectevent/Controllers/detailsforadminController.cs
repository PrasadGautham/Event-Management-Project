using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectevent.Models;


namespace projectevent.Controllers
{
    public class detailsforadminController : ApiController
    {
        // GET: api/Customerview
        public HttpResponseMessage Get()
        {
            var customers = agentrepo.custdet();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, customers);
            return response;

        }
        // GET: api/Customerview/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customerview
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customerview/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customerview/5
        public void Delete(int id)
        {
        }
    }
}
