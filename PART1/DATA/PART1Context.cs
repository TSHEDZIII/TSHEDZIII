using Microsoft.EntityFrameworkCore;
using PART1.MODELS;
using System;

namespace PART1.DATA
{
    
    
        public class PART1Context : DbContext
        {
            public PART1Context(DbContextOptions<PART1Context> options)
                : base(options)
            {
            }

            public DbSet <DISASTER> DISASTER { get; set; }
            public DbSet <REGISTER> REGISTER { get; set; }

            

        public DbSet <MonetaryDonation> MonetaryDonation { get; set; }
            

        public DbSet<PART1.MODELS.GoodsDonation> GoodsDonation { get; set; } = default!;
            

        public DbSet<PART1.MODELS.LOGIN> LOGIN { get; set; } = default!;
            

        public DbSet<PART1.MODELS.CHOICES> CHOICES { get; set; } = default!;

        public DbSet<PART1.MODELS.MONEYALLOCATIONS> MONEYALLOCATIONS { get; set; }

        public DbSet<PART1.MODELS.GoodsClass> GoodsClass { get; set; }

      

    }
    
}

