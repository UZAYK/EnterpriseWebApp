using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseWebApp.Models.Model
{
    [Table(" Blog ")]
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string PictureURL { get; set; }

        public int CategoryId { get; set; }
        public  Category Category { get; set; }
    }
}