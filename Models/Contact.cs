namespace EnterpriseWebApp.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Contact")]
    public partial class Contact
    {
        public int ContactId { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string WhatsApp { get; set; }

        [StringLength(50)]
        public string Facebook { get; set; }

        [StringLength(50)]
        public string Twitter { get; set; }

        [Required]
        [StringLength(50)]
        public string Instragram { get; set; }
    }
}
