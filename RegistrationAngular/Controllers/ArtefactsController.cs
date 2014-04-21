using System.Runtime.CompilerServices;
using System.Web.Mvc;
using AutoMapper;
using RegistrationAngular.Models;

[assembly: InternalsVisibleTo("RegistrationAngular.Tests")]
namespace RegistrationAngular.Controllers
{
    public class ArtefactsController : Controller
    {
        private readonly IMappingEngine _mappingEngine;
        //private readonly IGeneralServiceBase[] _generalServices;
        //private readonly IAdminServiceBase[] _adminServices;

        public ArtefactsController(IMappingEngine mappingEngine)
        {
            _mappingEngine = mappingEngine;
        }

        public ActionResult Index(string item)
        {
            var artefact = new Artefact
            {
                Id = 1,
                Name = "Fountain Pen",
                Barcode = "",
                Item = item
            };
            var student = _mappingEngine.Map<Artefact, StudentModel>(artefact);
            return View(artefact);
        }
    }
}