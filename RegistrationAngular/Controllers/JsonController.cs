using System;
using System.Net;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace RegistrationAngular.Controllers
{
    public class JsonController : Controller
    {
        protected new ActionResult Json(object data, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet)
        {
            if (Request.RequestType == WebRequestMethods.Http.Get && behavior == JsonRequestBehavior.DenyGet)
            {
                throw new InvalidOperationException("GET is not permitted for this request");
            }

            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(data, new JsonSerializerSettings
                            {
                                ContractResolver = new CamelCasePropertyNamesContractResolver()
                            }),
                ContentType = "application/json"
            };
        }
    }
}