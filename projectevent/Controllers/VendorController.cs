using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectevent.Models;

namespace projectevent.Controllers
{
    public class VendorController : ApiController
    {
        
        // GET: api/Vendor/5
        public HttpResponseMessage Get(int Id)
        {
            var selectvendor = vendorrepo.getvendor(Id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, selectvendor);
            return response;
        }
        // GET: api/Vendor
        public HttpResponseMessage Get(string username, string password)
        {
            var status = vendorrepo.Login(username, password);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, status);

            return response;
        }


        // GET: api/Vendor
        public string Get()
        {
            return "value";
        }

        // POST: api/Vendor
        public HttpResponseMessage Post(vendor vendor)
        {
            var Status = vendorrepo.RegisterVendor(vendor);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            return response;

        }
        // PUT: api/Vendor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vendor/5
        public void Delete(int id)
        {
        }
    }
}
