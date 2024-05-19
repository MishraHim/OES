namespace MOCKAPP.Server.Dto
{
    public class quizquestion
    {
        public int QuesId { get; set; }
        public string QuesName { get; set; }
        public List<quizoption> Options { get; set; }
    }

    public class quizoption
    {
        public string optionName { get; set; }
        public int optionID { get; set; }
       
    }

}
