using System.Web.Http;
using RegistrationAngular.Models;

namespace RegistrationAngular.Controllers
{
    public class InstructorsController : ApiController
    {
        public InstructorModel[] Get()
        {
            return GetInstructors();
        }

        private InstructorModel[] GetInstructors()
        {
            var instructors = new[]
                {
                    new InstructorModel {Name = "Rubeus Hagrid", Email = "hagrid@hogwarts.com", RoomNumber = 1001},
                    new InstructorModel {Name = "Severus Snape", Email = "snape@hogwarts.com", RoomNumber = 105},
                    new InstructorModel {Name = "Minerva McGonagall", Email = "mcgonagall@hogwarts.com", RoomNumber = 102},
                };
            return instructors;

            //var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            //var serializedInstructors = JsonConvert.SerializeObject(instructors, Formatting.None, settings);
            //return serializedInstructors;
        }

    }
}