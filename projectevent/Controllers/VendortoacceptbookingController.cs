using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectevent.ViewModel;
using projectevent.Models;

namespace projectevent.Controllers
{
    public class VendortoacceptbookingController : ApiController
    {
        // GET: api/Vendortoacceptbooking
        public HttpResponseMessage Get()
        {
            var Status = agentrepo.getcustomerandvenuedetails();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);

            return response;
        }

        // GET: api/Vendortoacceptbooking/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vendortoacceptbooking
       

        // PUT: api/Vendortoacceptbooking/5
        public void Put(int id)
        {
            agentrepo.acceptbook(id);


        }

        // DELETE: api/Vendortoacceptbooking/5
        public void Delete(int id)
        {
        }
    }
}
