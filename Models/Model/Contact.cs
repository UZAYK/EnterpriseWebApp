using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseWebApp.Models.Model
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [StringLength(250, ErrorMessage = "Must be 250 characters")]
        public string Address { get; set; }

        [StringLength(250, ErrorMessage = "Must be 250 characters")]
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string WhatsApp { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
    }
}