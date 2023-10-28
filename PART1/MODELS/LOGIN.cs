using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PART1.MODELS
{
    public class LOGIN
    {
        [Key]
        

        public int LOGINID { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string USERNAME { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string PASSWORD { get; set; }

        
        
        
        }

    }

