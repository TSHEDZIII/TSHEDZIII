using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PART1.MODELS
{
    public class REGISTER
    {
        [Key]
        public int REGID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string NAME { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        public string SURNAME { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string USERNAME { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string PASSWORD { get; set; }
    }
}
