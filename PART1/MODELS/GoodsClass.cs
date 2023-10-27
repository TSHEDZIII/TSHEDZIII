using System.ComponentModel.DataAnnotations;

namespace PART1.MODELS
{
    public class GoodsClass

    {

        [Key]
        public int ID { get; set; }

        [Required]
        public string DISASTER_LOCATION { get; set; }
        [Required]

        public string DISASTER_NAME { get; set; }
        [Required]

        


        public string GOODSNAME { get; set; }

        public int QUANTITY { get; set; }

        public bool IsActive { get; set; }

        public bool IsAllocated { get; set; }
    }
    class Disasters
    {
        public string DISASTER_LOCATION { get; set; }
        [Required]

        public string DISASTER_NAME { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
