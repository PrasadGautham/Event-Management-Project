using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectevent.Models;

namespace projectevent.Controllers
{
    public class customerController : ApiController
    {
        // GET: api/customer
        public HttpResponseMessage Get()
         {
            var se = searchlinq.searchall();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, se);
            return response;
        }
        public HttpResponseMessage Get(int id)
        {
            var reslt = searchlinq.Getvenue(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reslt);
            return response;
        }
        // GET: api/customer/5
        public HttpResponseMessage Get(string date1,int vid)
        {
            bool reslt = searchlinq.Getavail(date1,vid);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reslt);
            return response;
        }

        

        public HttpResponseMessage Get(string search)
        {
            var reslt = searchlinq.searchby(search);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, reslt);
            return response;
        }
        // POST: api/customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/customer/5
        public void Delete(int id)
        {
        }
    }
}
