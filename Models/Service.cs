namespace EnterpriseWebApp.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Service
    {
        public int ServiceId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string PictureURL { get; set; }
    }
}
