using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EnterpriseWebApp.Models.Model
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required,StringLength(50, ErrorMessage = "Must be 50 characters")]
        public string EMail { get; set; }

        [Required, StringLength(50, ErrorMessage = "Must be 50 characters")]
        public string Password { get; set; }
        public string Authority { get; set; }
    }
}