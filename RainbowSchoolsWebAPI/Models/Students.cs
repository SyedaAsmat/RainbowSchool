using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RainbowSchoolsWebAPI.Models
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        [ForeignKey("StudentId")]
        public ICollection<Marks>? Marks { get; set; }
    }
}
