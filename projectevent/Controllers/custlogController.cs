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
    public class custlogController : ApiController
    {
        // GET: api/custlog
        public HttpResponseMessage Get(string username,string password)
        {
            var status = Custmerlogrepo.Login(username,password);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, status);
           
            return response;
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/custlog/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/custlog
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/custlog/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/custlog/5
        public void Delete(int id)
        {
        }
    }
}
