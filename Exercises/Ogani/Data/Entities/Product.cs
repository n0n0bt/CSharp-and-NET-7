﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogani.Data.Entities
{

    [Table("tbl_products")]
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="Product name to long! Must be under 50 characters.")]
        public string ProductName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double ProductPrice { get; set; }

        [Required]
        [StringLength(250)]
        public string? ProductShortDescription { get; set; }
        
        public string? ProductDescription { get; set; }

        public string? ProductInformation { get; set; }

        public double Weight { get; set; }

        [StringLength(20)]
        public string? ProductImageName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfCreation { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfUpdate { get; set; }

        public Guid ProductCategoryCategoryID { get; set; }

        public virtual Category? ProductCategory { get; set; }
    }
}
