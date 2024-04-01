using System.ComponentModel.DataAnnotations;

namespace MOCKAPP.Server.Model
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }
        public string Papercode { get; set; }
        public DateTime days { get; set; }
        public DateTime Starttime { get; set; }
        public DateTime Endtime { get; set; }
    }
}
