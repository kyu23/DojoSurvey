using System.ComponentModel.DataAnnotations;

namespace DojoSurvey2.Models
{
    public class Survey
    {
        [Required(ErrorMessage="Give us a Name!!!")]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        [MinLength(10, ErrorMessage="TL;DR")]
        public string Comment { get; set; }
    }
}