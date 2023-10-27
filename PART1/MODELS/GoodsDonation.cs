using System;
using System.ComponentModel.DataAnnotations;

namespace PART1.MODELS
{
    public class GoodsDonation
    {
        [Key]
        
            [Required(ErrorMessage = "date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "description is required")]
        public string DESCRIPTION { get; set; }

        [Required(ErrorMessage = "category is required")]
        public string CATEGORY { get; set; }

        [Required(ErrorMessage = "Number of items is required")] 
        public int Number_of_items { get; set; }

            

        
    }
}
