using System.ComponentModel.DataAnnotations;

namespace MOCKAPP.Server.Model
{
    public class Options
    {
        [Key]
        public int optionID { get; set; }
        public string QuesId { get; set; }
        public string QuesName { get; set; }
        public int Correct { get; set; }
    }
}

