using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectevent.Models;
using projectevent.Controllers;

namespace projectevent.Controllers
{
    public class AgentController : ApiController
    {
        // GET: api/Agent
        public HttpResponseMessage Get()
        {
            var allagents = agentrepo.getallagent();
            HttpResponseMessage response= Request.CreateResponse(HttpStatusCode.OK,allagents);
            return response;
         }

        // GET: api/Agent/5
        public HttpResponseMessage Get(int id)
        {
            var agent =agentrepo.GetAgent(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, agent);
            return response;
        }

        // POST: api/Agent
        public HttpResponseMessage Post(agent newagent)
        {
            var Status = agentrepo.InsertAgent(newagent);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            return response;

        }


        // PUT: api/Agent/5
        public HttpResponseMessage Put(agent  modagent)
        {
            var Status = agentrepo.UpdateAgent(modagent);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            return response;
        }

        // DELETE: api/Agent/5
        public HttpResponseMessage Delete(int id)
        {
            var Status = agentrepo.DeleteAgent(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Status);
            return response;

        }
    }
}
