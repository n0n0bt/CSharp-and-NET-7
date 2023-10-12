using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Ogani.Data.Entities
{
    [Table("tbl_products")]
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }
        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(50, ErrorMessage = "Product name must be under 50 characters.")]
        [Display(Name = "Name")]
        public string? ProductName { get; set; }
        [Required(ErrorMessage = "Product price is required.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public double ProductPrice { get; set; }
        [Display(Name = "Product description")]
        public string? ProductDescription { get; set; }
        [StringLength(50, ErrorMessage = "Product image name must be under 50 characters.")]
        [Display(Name = "Image")]
        public string? ProductImageName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Creation")]
        public DateTime DateOfCreation { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Last Edit")]
        public DateTime DateOfUpdate { get; set; }
        [Required(ErrorMessage = "You must select a product category.")]
        [Display(Name = "Category")]
        public Guid ProductCategoryCategoryID { get; set; }
        [ForeignKey("ProductCategoryCategoryID")]
        public virtual Category? ProductCategory { get; set; }
    }
}