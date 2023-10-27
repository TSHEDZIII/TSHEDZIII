using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace PART1.MODELS
{
    public class ACTIVEDISASTER
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }

    public class GOODS
    {
        public int GOODSID { get; set; }

        public string NAME { get; set; }

        public int QUANTITY { get; set; }

    }

    public class ALLOCATION
    {
        public ACTIVEDISASTER ACTIVEDISASTER { get; set; }
        public GOODS GOODS { get; set; }
        public int Quantity { get; set; }
    }
}

