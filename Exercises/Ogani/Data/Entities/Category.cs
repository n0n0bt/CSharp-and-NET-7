using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Ogani.Data.Entities
{
    [Table("tbl_categories")]
    public class Category
    {
        public Category()
        {
            CategoryID = Guid.NewGuid();
            CategoryName = string.Empty;
            CategoryDescription = string.Empty;
        }
        public Category(string categoryName, string categoryDescription)
        {
            CategoryID = Guid.NewGuid();
            CategoryName = categoryName ?? throw new ArgumentNullException(nameof(categoryName));
            CategoryDescription = categoryDescription ?? throw new ArgumentNullException(nameof(categoryDescription));
        }
        [Key]
        public Guid CategoryID { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(150, ErrorMessage = "Category name must be less than 150 characters.")]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        [StringLength(500, ErrorMessage = "Category description must be less than 500 characters.")]
        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }
        [StringLength(50, ErrorMessage = "Category image name must be less than 50 characters.")]
        [Display(Name = "Image")]
        public string? CategoryImageName { get; set; }
        // Define a navigation property for the related products
        public virtual ICollection<Product> Products { get; set; }
    }
}