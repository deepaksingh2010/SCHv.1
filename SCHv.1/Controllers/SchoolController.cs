using SCHEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SCHv._1.Controllers
{
    public class SchoolController : BaseController<School>
    {
        public SchoolController() : base()
        {
        }
        [HttpPost]
        public override HttpResponseMessage AddEntity([FromBody] School entity)
        {
            entity.TimeCreated = DateTime.Now;
            entity.TimeUpdated = DateTime.Now;
            HttpResponseMessage response = base.AddEntity(entity);
            httpResponseMessage.Headers.Location = new Uri(Request.RequestUri + "/" + (entity.SchoolID).ToString());
            return response;
        }
        [HttpPut]
        public override HttpResponseMessage UpdateEntity([FromBody] School entity)
        {
            HttpResponseMessage response = base.UpdateEntity(entity);
            httpResponseMessage.Headers.Location = new Uri(Request.RequestUri + "/" + (entity.SchoolID).ToString());
            return response;
        }
    }
}
