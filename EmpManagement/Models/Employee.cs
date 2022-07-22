using System.ComponentModel.DataAnnotations;

namespace EmpManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [StringLength(255)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string Gender { get; set; }
        [Required]
        [StringLength(255)]
        public string Department { get; set; }
        [Required]
        [StringLength(255)]
        public string EducationLevel { get; set; }
        [Required]

        public int PhoneNumber { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; } 


    }
}
