using System.ComponentModel.DataAnnotations;

namespace RegistrationAngular.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Please enter a First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter an Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }
    }
}