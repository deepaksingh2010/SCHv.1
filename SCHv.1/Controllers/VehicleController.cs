using SCHEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SCHv._1.Controllers
{
    public class VehicleController : BaseController<Vehicle>
    {
        public VehicleController() : base()
        {
        }
        [HttpPost]
        public override HttpResponseMessage AddEntity([FromBody] Vehicle entity)
        {
            entity.TimeCreated = DateTime.Now;
            entity.TimeUpdated = DateTime.Now;
            HttpResponseMessage response = base.AddEntity(entity);
            httpResponseMessage.Headers.Location = new Uri(Request.RequestUri + "/" + (entity.VehicleID).ToString());
            return response;
        }
        [HttpPost]
        protected override HttpResponseMessage UpdateEntity([FromBody] Vehicle entity)
        {
            HttpResponseMessage response = base.UpdateEntity(entity);
            httpResponseMessage.Headers.Location = new Uri(Request.RequestUri + "/" + (entity.VehicleID).ToString());
            return response;
        }
    }
}
