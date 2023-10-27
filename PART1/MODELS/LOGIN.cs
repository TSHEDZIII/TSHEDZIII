using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PART1.MODELS
{
    public class LOGIN
    {
        [Key]
        

        public int LOGINID { get; set; }
       
        public string USERNAME { get; set; }
        
        public string PASSWORD { get; set; }

        
        
        
        }

    }

