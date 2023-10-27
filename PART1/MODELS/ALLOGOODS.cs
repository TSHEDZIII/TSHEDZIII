using System.ComponentModel.DataAnnotations;

namespace PART1.MODELS
{
    public class ALLOGOODS
    {
        
        public class Disaster
        {
            [Key]

            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public class GoodsAllocation
        {
            [Key]
            public int Id { get; set; }
            public int DisasterId { get; set; }
            public string GoodsName { get; set; }
            public int Quantity { get; set; }
        }
    }
}
