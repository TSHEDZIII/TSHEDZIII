using System.ComponentModel.DataAnnotations;

namespace PART1.MODELS
{
    public class GoodsClass

    {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "location is required")]
        public string DISASTER_LOCATION { get; set; }
        [Required(ErrorMessage = "name is required")]
        public string DISASTER_NAME { get; set; }

        [Required(ErrorMessage = "good name is required")]
        public string GOODSNAME { get; set; }
        [Required(ErrorMessage = "quantity is required")]
        public int QUANTITY { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public bool IsAllocated { get; set; }
    }
    class Disasters
    {
        [Required]
        public string DISASTER_LOCATION { get; set; }
        [Required]

        public string DISASTER_NAME { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
