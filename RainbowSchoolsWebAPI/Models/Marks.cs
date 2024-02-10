using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RainbowSchoolsWebAPI.Models
{
    [Table("Marks")]
    public class Marks
    {
        [Key]
        public int MarksId { get; set; }
        public Students? Students { get; set; }
        public Subjects? Subjects { get; set; }
        public int MarksObtained { get; set; }
        
    }
}
