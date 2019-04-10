using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectevent.Models;
using projectevent.ViewModel;

namespace projectevent.Controllers
{
    public class VenueController : ApiController
    {
        // GET: api/Venue
        public HttpResponseMessage Get()
        {
            var allvenues = venuerepo.getallvenues();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, allvenues);
            return response;
        }


        // GET: api/Venue/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/venue
        public HttpResponseMessage Post(venue newvenue)
        {
            var Status = venuerepo.InsertVenue(newvenue);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            return response;

        }

        // PUT: api/venue/5
        public HttpResponseMessage Put(venueorgview modvenue)
        {
            var Status = venuerepo.UpdateVenue(modvenue);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            return response;
        }


        // DELETE: api/Venue/5
        public void Delete(int id)
        {
        }
    }
}
