using System.ComponentModel.DataAnnotations;

namespace EFCORE.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Range(18, 100)]
        public int StudentAge { get; set; }

        [Required]
        public string? EmailAddress { get; set; }
    }
}
