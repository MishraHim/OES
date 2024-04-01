using System.ComponentModel.DataAnnotations;

namespace MOCKAPP.Server.Model
{
    public class Paper
    {
        [Key]
        public int PaperID { get; set; }
        public string Papercode { get; set; }
        public int sectionId { get; set; }
        public int courseId { get; set; }     
        public string PaperName { get; set; }       
    }
}
