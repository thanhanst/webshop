using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Model.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Alias { set; get; }

        public string Image { set; get; }
        public string MoreImage { set; get; }

        [Required]
        public double Price { set; get; }

        public double Promotion { set; get; }
        public int Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }

        [Required]
        public DateTime CreateDate { set; get; }

        [Required]
        public string CreateBy { set; get; }

        public DateTime UpdateDate { set; get; }
        public string UpdateBy { set; get; }
        public bool Status { set; get; }
        public bool HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        public int ViewCount { set; get; }
    }
}