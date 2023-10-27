using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PART1.MODELS
{
    public class REGISTER
    {
        [Key]

        public int REGID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }

        public string USERNAME { get; set; }

        public string PHONE_NUMBER { get; set; }

        public string PASSWORD { get; set; }

        public string CONFIRM_PASSWORD { get; set; }



    }
}
