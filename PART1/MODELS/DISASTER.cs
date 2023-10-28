using System.ComponentModel.DataAnnotations;


namespace PART1.MODELS
{
    public class DISASTER
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "date is required")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "date is required")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "location is required")]
        public string LOCATION { get; set; }
        [Required(ErrorMessage = "Descriptio is required")]
        public string DESCRIPTION { get; set; }
        [Required(ErrorMessage = "Aid type is required")]
        public string AidTypes { get; set; }
    }

   
}
