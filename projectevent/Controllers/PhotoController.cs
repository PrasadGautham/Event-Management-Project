using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectevent.Models;


namespace projectevent.Controllers
{
    public class PhotoController : ApiController
    {
        // GET: api/photo
        public HttpResponseMessage Get()
        {
            var allphotographers = photorepo.getallphotographers();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK,allphotographers);
            return response;
        }

        // GET: api/photo/5
        public HttpResponseMessage Get(int id)
        {
            var photo = photorepo.GetPhoto(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK,photo);
            return response;
        }

        // POST: api/photo
        public HttpResponseMessage Post(photography newphoto)
        {
            var Status = photorepo.InsertPhoto(newphoto);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            return response;

        }
        // PUT: api/photo/5
        public HttpResponseMessage Put(photography modphoto)
        {
            var Status = photorepo.UpdatePhoto(modphoto);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            return response;
        }

        // DELETE: api/photo/5
        public HttpResponseMessage Delete(int id)
        {
            var Status = photorepo.DeletePhoto(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            return response;
        }
    }
}
