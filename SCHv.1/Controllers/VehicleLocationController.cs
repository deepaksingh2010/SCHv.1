using SCHEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SCHv._1.Controllers
{
    public class VehicleLocationController : BaseController<VehicleLocation>
    {
        public VehicleLocationController() : base()
        {
        }
        [HttpPost]
        public override HttpResponseMessage AddEntity([FromBody] VehicleLocation entity)
        {
            entity.TimeCreated = DateTime.Now;
            entity.TimeUpdated = DateTime.Now;
            HttpResponseMessage response = base.AddEntity(entity);
            httpResponseMessage.Headers.Location = new Uri(Request.RequestUri + "/" + (entity.VehicleLocationID).ToString());
            return response;
        }
        [HttpPost]
        public override HttpResponseMessage UpdateEntity([FromBody] VehicleLocation entity)
        {
            HttpResponseMessage response = base.UpdateEntity(entity);
            httpResponseMessage.Headers.Location = new Uri(Request.RequestUri + "/" + (entity.VehicleLocationID).ToString());
            return response;
        }
    }
}
