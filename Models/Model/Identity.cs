using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EnterpriseWebApp.Models.Model
{
    [Table("Identity")]
    public class Identity
    {
        [Key]
        public int IdentityId { get; set; }

        [DisplayName(" Site Name ")]
        public string Title { get; set; }

        [DisplayName(" Site Keywords ")]
        public string Keywords { get; set; }

        [DisplayName(" Site Description ")]
        public string Description { get; set; }

        [DisplayName(" Site Logo ")]
        public string LogoURL { get; set; }

        [DisplayName(" Site Title ")]
        public string Unvan { get; set; }
    }
}