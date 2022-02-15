using System;
using System.ComponentModel.DataAnnotations;

namespace dojo_survey_w_validation.Models
{
    public class Ninja
    {
        [Required(ErrorMessage = "Must have a Name")]
        [MinLength(2, ErrorMessage ="Name must be at least 2 characters")]
        public string Name { get; set; }
        public string Location { get; set; }
        public string FavoriteLanguage { get; set; }

        [MaxLength(20, ErrorMessage ="Comment if present cannot be more than 20 characters")]
        public string Comment { get; set; }
    }
}
