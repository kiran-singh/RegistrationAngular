using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RegistrationAngular.Models;

namespace RegistrationAngular.Controllers
{
    public class AccountController : ApiController
    {
        public HttpResponseMessage Post(HttpRequestMessage request, StudentModel student)
        {
            if (ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK); 
                //return request.CreateErrorResponse(HttpStatusCode.BadRequest, "no way, hose...");
            }
            return request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessages());
        }

        private IEnumerable<string> GetErrorMessages()
        {
            return ModelState.Values.SelectMany(x => x.Errors.Select(y => y.ErrorMessage));
        }
    }
}
