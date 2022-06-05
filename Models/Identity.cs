namespace EnterpriseWebApp.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Identity
    {
        public int IdentityId { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Keywords { get; set; }

        [StringLength(500)]
        public string Descriptio { get; set; }

        [StringLength(250)]
        public string LogoURL { get; set; }

        [StringLength(250)]
        public string Unvan { get; set; }
    }
}
