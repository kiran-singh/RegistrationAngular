using System.Web.Http;
using RegistrationAngular.Models;
using RegistrationAngular.Service;

namespace RegistrationAngular.Controllers
{
    public class ClassesController : ApiController
    {
        private readonly ISubjectService _subjectService;

        public ClassesController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public PeriodModel[][] Get()
        {
            return _subjectService.GetAll();
        }
    }
}