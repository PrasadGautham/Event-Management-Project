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
    public class ReviewController : ApiController
    {
        // GET: api/Review/5
        public HttpResponseMessage Get(int id)
        {
            var allreview = agentrepo.reviewdatabasedonvenue(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, allreview);
            return response;
        }

        
       

        // POST: api/Review
        public HttpResponseMessage Post(review rev)
        {
            var Status = agentrepo.addreview(rev);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            
            return response;
        }

        // PUT: api/Review/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Review/5
        public void Delete(int id)
        {
        }
    }
}
