using System.ComponentModel.DataAnnotations;


namespace PART1.MODELS
{
    public class DISASTER
    {
        [Key]
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public string LOCATION { get; set; }
        public string DESCRIPTION { get; set; }
        public string AidTypes { get; set; }
    }

   
}
