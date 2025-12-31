using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementActivity.Model
{
    public class EmployeeMgt
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}
