using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOCKAPP.Server.Model
{
    public class Options
    {
        [Key]
        public int optionID { get; set; }
      
        public int Ques_Id { get; set; }
        public string PaperID { get; set; }
        public string optionName { get; set; }
        public int Correct { get; set; }
        

      
    }
}

