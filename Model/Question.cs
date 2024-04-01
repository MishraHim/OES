using System.ComponentModel.DataAnnotations;

namespace MOCKAPP.Server.Model
{
    public class Question
    {
        [Key]
        public int QuesId { get; set; }
        public int PaperID { get; set; }
        public string QuesName { get; set; }
        public string Questype { get; set; }
        public string Marks { get; set; }
    }
}
