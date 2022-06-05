using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EnterpriseWebApp.Models.Model
{
    [Table("AboutUs")]
    public class AboutUs
    {
        [Key]
        public int AboutUsId { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}