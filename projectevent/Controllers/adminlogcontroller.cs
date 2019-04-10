
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
    public class adminlogController : ApiController
    {
        // GET: api/adminlog
        public HttpResponseMessage Get(string username, string password)
        {
            var status = agentrepo.Login(username, password);
            HttpResponseMessage response = Request.CreateResponse
                (HttpStatusCode.OK, status);

            return response;
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/adminlog/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/adminlog
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/adminlog/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/adminlog/5
        public void Delete(int id)
        {
        }
    }
}
