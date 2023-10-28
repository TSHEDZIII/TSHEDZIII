﻿using System.ComponentModel.DataAnnotations;

namespace PART1.MODELS
{
    public class MONEYALLOCATIONS
    {

        
        
            [Key]
            public int ID { get; set; }

            [Required]
            public string DISASTER_LOCATION { get; set; }
            [Required]

            public string DISASTER_DESCRIPTION { get; set; }
            [Required]

            public string ALLOCATE_FUNDS { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
       
    
    class Disaster
    {

        [Required]
        public bool IsActive { get; set; }
    }

}
