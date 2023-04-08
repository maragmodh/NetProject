using System.ComponentModel.DataAnnotations;

namespace MaragWeb.Models
{
    public class Department
    {

        [Key]
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }

    }
}
