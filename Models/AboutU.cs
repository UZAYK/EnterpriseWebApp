namespace EnterpriseWebApp.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class AboutU
    {
        [Key]
        public int AboutUsId { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
