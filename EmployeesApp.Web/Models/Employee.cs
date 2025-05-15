using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [HardCodedString("NSFW word here")]
        [Required/*(ErrorMessage = "Enter a name")*/]
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }

    public class HardCodedStringAttribute : ValidationAttribute
    {
        private readonly string _hardCodedString;
        public HardCodedStringAttribute(string hardCodedString)
        {
            _hardCodedString = hardCodedString;
        }
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string strValue && strValue == _hardCodedString)
            {
                return new ValidationResult($"The value '{_hardCodedString}' is not allowed.");
            }
            return ValidationResult.Success!;
        }
    }
}
