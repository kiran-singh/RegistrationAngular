using System.Web.Http;
using RegistrationAngular.Models;

namespace RegistrationAngular.Controllers
{
    public class CoursesController : ApiController
    {
        public CourseModel[] Get()
        {
            return GetCourseModels();
        }

        private CourseModel[] GetCourseModels()
        {
            var courses = new[]
                {
                    new CourseModel {Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                    new CourseModel {Number = "DARK502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                    new CourseModel {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"},
                };
            return courses;

            //var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            //var serializeCourses = JsonConvert.SerializeObject(courses, Formatting.None, settings);
            //return serializeCourses;
        }

    }
}