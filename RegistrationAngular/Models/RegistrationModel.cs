namespace RegistrationAngular.Models
{
    public class RegistrationModel
    {
        public string Courses { get; set; }
        public string Instructors { get; set; }
    }

    public class CourseModel
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
    }

    public class InstructorModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoomNumber { get; set; }
    }
}