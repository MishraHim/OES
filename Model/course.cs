using System.ComponentModel.DataAnnotations;

namespace MOCKAPP.Server.Model
{
    public class course
    {
        [Key]
        public int courseId { get; set; }
        public int typeId { get; set; }
        public string courseName { get; set; }
    }
}
