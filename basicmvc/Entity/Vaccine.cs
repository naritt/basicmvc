using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace basicmvc.Entity
{
    public partial class Vaccine
    {
        public int Id { get; set; }

        [Display(Name = "Vaccine name")]
        [Required(ErrorMessage = "Please provide vaccine name")]
        public string Name { get; set; }

        [Display(Name = "Vaccine stock")]
        [Required(ErrorMessage = "Please provide vaccine stock")]
        public int Stock { get; set; }

        [Display(Name = "Vaccine price")]
        [Required(ErrorMessage = "Please provide vaccine price")]
        public int Price { get; set; }
    }
}
