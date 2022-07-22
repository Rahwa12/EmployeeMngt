using System.ComponentModel.DataAnnotations;

namespace EmpManagement.Resources
{
    public class EmployeeResource
    {
    
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string EducationLevel { get; set; }
        [Required]

        public int PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }    

    }
}
