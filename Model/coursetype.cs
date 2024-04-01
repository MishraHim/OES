using System.ComponentModel.DataAnnotations;

namespace MOCKAPP.Server.Model
{
    public class coursetype
    {
        [Key]
        public int typeId { get; set; }
        public string Type { get; set; }
    }
}
