using System.ComponentModel.DataAnnotations;

namespace MOCKAPP.Server.Model
{
    public class section
    {
        [Key]
        public int sectionId { get; set; }
        public int courseId { get; set; }
        public string sectionName { get; set; }
    }
}
