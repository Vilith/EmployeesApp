using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a name")]
        public string Name { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Enter an e-mail")]
        public string Email { get; set; } = string.Empty;

    }
}
