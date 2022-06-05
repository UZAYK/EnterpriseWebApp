namespace EnterpriseWebApp.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Blog
    {
        public int BlogId { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        public string Contents { get; set; }

        [StringLength(250)]
        public string PictureURL { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
