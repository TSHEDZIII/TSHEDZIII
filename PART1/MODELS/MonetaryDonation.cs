using System;
using System.ComponentModel.DataAnnotations;

namespace PART1.MODELS
{
    public class MonetaryDonation
    {
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        

     
         [Required(ErrorMessage = "Amount is required")]
        public string Amount { get; set; }


    }
}
