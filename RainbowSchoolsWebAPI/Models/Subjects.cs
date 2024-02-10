using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RainbowSchoolsWebAPI.Models
{
    [Table("Subjects")]
    public class Subjects
    {
        [Key]
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        [ForeignKey("SubjectId")]
        public ICollection<Marks>? Marks { get; set; }
    }
}
