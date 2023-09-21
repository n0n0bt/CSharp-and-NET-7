using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogani.Data.Entities
{
    [Table("tbl_categories")]
    public class Category
    {
        public Category()
        {
            CategoryID = new Guid();
            CategoryName = string.Empty;
            CategoryDescription = string.Empty;
        }

        public Category(string? categoryName, string? categoryDescription)
        {
            CategoryID = new Guid();
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
        }

        [Key]
        public Guid CategoryID { get; set; }

        [StringLength(150, ErrorMessage = "Category name is too long. Must be last than 150 characters!")]
        public string? CategoryName { get; set; }

        [StringLength(500, ErrorMessage = "Category Description is too long. Must be last than 500 characters!")]
        public string? CategoryDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
