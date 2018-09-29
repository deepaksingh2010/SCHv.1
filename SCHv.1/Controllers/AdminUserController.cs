using SCHEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SCHv._1.Controllers
{
    public class AdminUserController : BaseController<AdminUser>
    {
        public AdminUserController() : base()
        {
        }
        [HttpPost]
        public override HttpResponseMessage AddEntity([FromBody] AdminUser entity)
        {
            entity.TimeCreated = DateTime.Now;
            entity.TimeUpdated = DateTime.Now;
            HttpResponseMessage response = base.AddEntity(entity);
            httpResponseMessage.Headers.Location = new Uri(Request.RequestUri + "/" + (entity.AdminUserID).ToString());
            return response;
        }
        [HttpPost]
        public override HttpResponseMessage UpdateEntity([FromBody] AdminUser entity)
        {
            HttpResponseMessage response = base.UpdateEntity(entity);
            httpResponseMessage.Headers.Location = new Uri(Request.RequestUri + "/" + (entity.AdminUserID).ToString());
            return response;
        }
    }
}
